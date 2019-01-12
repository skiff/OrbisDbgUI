using System;
using System.Windows.Forms;
using System.IO;
using System.Collections.Generic;
using System.Threading;

namespace OrbisDbgUI {
    public partial class MainForm : Form {
        //Debugging Variables
        public string SelectedProcess = "";
        public string IPAddress = "";
        public bool bUpdatedOnPause = false;
        public List<Process> pList = new List<Process>();
        public List<Breakpoint> breakpoints = new List<Breakpoint>();
        public Thread statusThread = null;
        public ulong PreviousRip = 0x0;

        //Windows
        public ProcessesForm processesForm = null;
        public RegistersForm registersForm = null;
        public BreakpointForm breakpointForm = null;
        public MemoryForm memoryForm = null;
        public DisassemblyForm disassemblyForm = null;

        public MainForm() {
            InitializeComponent();
            IPAddressToolStripTextBox.Text = Properties.Settings.Default.IPAddress;
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e) {
            if (statusThread != null && statusThread.IsAlive)
                statusThread.Abort();

            Properties.Settings.Default.IPAddress = IPAddressToolStripTextBox.Text;
            Properties.Settings.Default.Save();
        }

        public void SetButtonsEnabled(bool enabled) {
            AttachToolStripButton.Enabled = !enabled;
            attachProcessToolStripMenuItem.Enabled = !enabled;

            DetachToolStripButton.Enabled = enabled;
            detachProcessToolStripMenuItem.Enabled = enabled;

            PlayToolStripButton.Enabled = enabled;
            continueToolStripMenuItem.Enabled = enabled;

            PauseToolStripButton.Enabled = enabled;
            pauseToolStripMenuItem.Enabled = enabled;

            StepToolStripButton.Enabled = enabled;
            stepInToolStripMenuItem.Enabled = enabled;

            BreakpointToolStripButton.Enabled = enabled;
            breakpointsWindowToolStripMenuItem.Enabled = enabled;

            MemoryToolStripButton.Enabled = enabled;
            memoryWindowToolStripMenuItem.Enabled = enabled;

            RegistersToolStripButton.Enabled = enabled;
            registersWindowToolStripMenuItem.Enabled = enabled;

            DisassemblyToolStripButton.Enabled = enabled;
            disassemblyWindowToolStripMenuItem.Enabled = enabled;

            ExitToolStripButton.Enabled = true;
            quitGameToolStripMenuItem.Enabled = true;

            loadELFFileToolStripMenuItem.Enabled = enabled;

            if (enabled) {
                if(statusThread == null || !statusThread.IsAlive) {
                    statusThread = new Thread(() => CheckForPausedStateThread(this));
                    statusThread.Start();
                }
            }
            else {
                if (statusThread != null && statusThread.IsAlive)
                    statusThread.Abort();
            }
        }

        public bool AllowDetach() {
            bool allowDetach = true;

            for(int i = 0; i < breakpoints.Count; i++) {
                if (breakpoints[i].process.Equals(SelectedProcess) && breakpoints[i].enabled)
                    allowDetach = false;
            }

            return allowDetach;
        }

        public bool AllowQuit() {
            if (!AllowDetach())
                return false;

            Process current = null;
            for (int i = 0; i < pList.Count; i++) {
                if (pList[i].name.Equals(SelectedProcess)) {
                    current = pList[i];
                    break;
                }
            }

            return current == null || current.attached == 0;
        }

        private void SendPlayloadFunction() {
            IPAddress = IPAddressToolStripTextBox.Text;
            OrbisDbg.SetIP(IPAddress);

            byte[] OrbisDbgPayload = File.ReadAllBytes(@"OrbisDbg\OrbisDbg.bin");
            OrbisDbg.SendPayload(OrbisDbgPayload);
        }

        private void ConnectToConsole() {
            IPAddress = IPAddressToolStripTextBox.Text;
            OrbisDbg.SetIP(IPAddress);

            pList = OrbisDbg.GetProcessList();
            if (pList.Count > 0) {
                AttachToolStripButton.Enabled = true;
                ProcessesToolStripButton.Enabled = true;

                bool bAnyProcessesAttached = false;
                for (int i = 0; i < pList.Count; i++)
                    if (pList[i].attached != 0)
                        bAnyProcessesAttached = true;

                if (bAnyProcessesAttached) {
                    SelectAttachedTarget selectAttachedTarget = new SelectAttachedTarget(pList);
                    selectAttachedTarget.ShowDialog();
                    if (selectAttachedTarget.DialogResult == DialogResult.OK) {
                        SelectedProcess = selectAttachedTarget.SelectedProcess;
                        OrbisDbg.SetProcess(selectAttachedTarget.SelectedProcess);

                        SetButtonsEnabled(true);
                    }
                }

                processesWindowToolStripMenuItem.Enabled = true;
                ProcessesToolStripButton.Enabled = true;
            }
            else {
                string message = "Orbis Debugger could not connect to the Playstation 4 System\n" +
                                "Please make sure your console is turned on and the payload has been loaded";
                MessageBox.Show(message, "Error Connecting");
            }
        }

        private void OpenProcessWindow() {
            pList = OrbisDbg.GetProcessList();
            if (pList.Count > 0) {
                if (processesForm == null) {
                    processesForm = new ProcessesForm(this);
                    processesForm.MdiParent = this;
                    processesForm.Show();
                }
                else {
                    processesForm.UpdateProcesses();
                    processesForm.BringToFront();
                }
            }
            else {
                string message = "Orbis Debugger could not connect to the Playstation 4 System\n" +
                               "Please make sure your console is turned on and the payload has been loaded";
                MessageBox.Show(message, "Error Grabbing Processes");
            }
        }

        private void AttachToProcess() {
            OpenProcessWindow();
        }

        private void DetachFromProcess() {
            OpenProcessWindow();
        }

        private void ContinueProcess() {
            bUpdatedOnPause = false;
            PreviousRip = 0x0;

            if (OrbisDbg.IsProcessPaused()) {
                OrbisDbg.ClearSingleStep();

                if(breakpoints.Count > 0) {
                    for(int i = 0; i < breakpoints.Count; i++) {
                        Breakpoint bp = breakpoints[i];
                        if (SelectedProcess.Equals(bp.process) && bp.enabled) {
                            OrbisDbg.Ext.WriteByte(bp.address, 0xCC);
                        }
                    }
                }

                if (registersForm != null)
                    registersForm.FreezeRegisters();

                if (disassemblyForm != null)
                    disassemblyForm.ClearDisassembly();

                OrbisDbg.ContinueProcess();
            }
        }

        private void BreakProcess() {
            if (!OrbisDbg.IsProcessPaused()) {
                if (OrbisDbg.SendProcessSignal(OrbisDbg.SIGNALS.SIGSTOP) == 0)
                    return;

                if (breakpoints.Count > 0) {
                    for (int i = 0; i < breakpoints.Count; i++) {
                        Breakpoint bp = breakpoints[i];
                        if (SelectedProcess.Equals(bp.process) && bp.enabled)
                            OrbisDbg.Ext.WriteByte(bp.address, bp.instruction);
                    }
                }

                OrbisDbg.registers regs = OrbisDbg.GetRegisters();

                if (registersForm != null)
                    registersForm.UpdateRegisterWindow(regs);

                if(memoryForm != null) {
                    byte[] mem = OrbisDbg.GetMemory(regs.r_rip, 0x1000);
                    memoryForm.UpdateMemoryView(regs.r_rip, 0x1000, mem);
                }

                if(disassemblyForm != null) {
                    byte[] memory = OrbisDbg.GetMemory(regs.r_rip, 0x100);
                    disassemblyForm.UpdateDisassembly(regs.r_rip, memory, disassemblyForm.IsShowingBytes());
                }

                OrbisDbg.SetSingleStep();
            }
        }

        private void StepProcess() {
            if (OrbisDbg.IsProcessPaused()) {
                OrbisDbg.SingleStep();
            }
        }

        private void OpenBreakpointWindow() {
            if (breakpointForm == null) {
                breakpointForm = new BreakpointForm(this);
                breakpointForm.MdiParent = this;
                breakpointForm.Show();
            }
            else {
                breakpointForm.BringToFront();
            }
        }

        private void OpenMemoryWindow() {
            if (memoryForm == null) {
                memoryForm = new MemoryForm(this);
                memoryForm.MdiParent = this;
                memoryForm.Show();
            }
            else {
                memoryForm.BringToFront();
            }
        }

        private void OpenRegistersWindow() {
            if (registersForm == null) {
                registersForm = new RegistersForm(this);
                registersForm.MdiParent = this;
                registersForm.Show();
            }
            else {
                registersForm.BringToFront();
            }
        }

        private void OpenDisassemblyWindow() {
            if (disassemblyForm == null) {
                disassemblyForm = new DisassemblyForm(this);
                disassemblyForm.MdiParent = this;
                disassemblyForm.Show();
            }
            else {
                disassemblyForm.BringToFront();
            }
        }

        private void ForceQuitProcess() {
            if (AllowQuit()) {
                if (memoryForm != null)
                    memoryForm.Close();

                if (disassemblyForm != null)
                    disassemblyForm.Close();

                if (registersForm != null)
                    registersForm.Close();

                if (breakpointForm != null)
                    breakpointForm.Close();

                OrbisDbg.SendProcessSignal(OrbisDbg.SIGNALS.SIGKILL);

                SetButtonsEnabled(false);
            }
            else {
                MessageBox.Show("Please clear breakpoints and detach before quittting the game", "Process can't quit");
            }
        }

        private void RebootConsole() {
            OrbisDbg.Reboot();

            breakpoints.Clear();
            if (breakpointForm != null)
                breakpointForm.Close();

            if (memoryForm != null)
                memoryForm.Close();

            if (disassemblyForm != null)
                disassemblyForm.Close();

            if (registersForm != null) 
                registersForm.Close();

            SetButtonsEnabled(false);
            AttachToolStripButton.Enabled = false;
            ProcessesToolStripButton.Enabled = false;
        }

        private void loadELFFileToolStripMenuItem_Click(object sender, EventArgs e) {
            try {
                OpenFileDialog openFileDialog1 = new OpenFileDialog();
                openFileDialog1.Filter = "ELF Files|*.elf";
                openFileDialog1.Title = "Select a File";

                if (openFileDialog1.ShowDialog() == DialogResult.OK) {
                    string fileName = openFileDialog1.FileName;
                    byte[] fileBytes = File.ReadAllBytes(fileName);
                    if(OrbisDbg.InjectELF(fileBytes, fileBytes.Length) == 0) {
                        string message = "Orbis Debugger could not load the selected ELF\n" +
                               "Please make sure you are attached to the desired process";
                        MessageBox.Show(message, "Error Loading ELF");
                    }
                }
            }
            catch (Exception) {
                MessageBox.Show("Unable to open File Dialog");
            }
        }

        //Toolstrip Options
        private void SendPayloadToolStripButton_Click(object sender, EventArgs e) => SendPlayloadFunction();
        private void ConnectToolStripButton_Click(object sender, EventArgs e) => ConnectToConsole();
        private void ProcessesToolStripButton_Click(object sender, EventArgs e) => OpenProcessWindow();
        private void AttachToolStripButton_Click(object sender, EventArgs e) => AttachToProcess();
        private void DetachToolStripButton_Click(object sender, EventArgs e) => DetachFromProcess();
        private void PlayToolStripButton_Click(object sender, EventArgs e) => ContinueProcess();
        private void PauseToolStripButton_Click(object sender, EventArgs e) => BreakProcess();
        private void StepToolStripButton_Click(object sender, EventArgs e) => StepProcess();
        private void BreakpointToolStripButton_Click(object sender, EventArgs e) => OpenBreakpointWindow();
        private void MemoryToolStripButton_Click(object sender, EventArgs e) => OpenMemoryWindow();
        private void RegistersToolStripButton_Click(object sender, EventArgs e) => OpenRegistersWindow();
        private void DisassemblyToolStripButton_Click(object sender, EventArgs e) => OpenDisassemblyWindow();
        private void ExitToolStripButton_Click(object sender, EventArgs e) => ForceQuitProcess();
        private void RebootToolStripButton_Click(object sender, EventArgs e) => RebootConsole();

        //Task Bar Options
        private void sendPayloadToolStripMenuItem_Click(object sender, EventArgs e) => SendPlayloadFunction();
        private void connectToolStripMenuItem_Click(object sender, EventArgs e) => ConnectToConsole();
        private void attachProcessToolStripMenuItem_Click(object sender, EventArgs e) => AttachToProcess();
        private void detachProcessToolStripMenuItem_Click(object sender, EventArgs e) => DetachFromProcess();
        private void quitGameToolStripMenuItem_Click(object sender, EventArgs e) => ForceQuitProcess();
        private void rebootConsoleToolStripMenuItem_Click(object sender, EventArgs e) => RebootConsole();
        private void continueToolStripMenuItem_Click(object sender, EventArgs e) => ContinueProcess();
        private void pauseToolStripMenuItem_Click(object sender, EventArgs e) => BreakProcess();
        private void stepInToolStripMenuItem_Click(object sender, EventArgs e) => StepProcess();
        private void breakpointsWindowToolStripMenuItem_Click(object sender, EventArgs e) => OpenBreakpointWindow();
        private void processesWindowToolStripMenuItem_Click(object sender, EventArgs e) => OpenProcessWindow();
        private void memoryWindowToolStripMenuItem_Click(object sender, EventArgs e) => OpenMemoryWindow();
        private void registersWindowToolStripMenuItem_Click(object sender, EventArgs e) => OpenRegistersWindow();
        private void disassemblyWindowToolStripMenuItem_Click(object sender, EventArgs e) => OpenDisassemblyWindow();

        private void UpdateFormsOnPaused() {
            bool isPaused = OrbisDbg.IsProcessPaused();
            if (isPaused) {
                OrbisDbg.registers regs = OrbisDbg.GetRegisters();

                if (!bUpdatedOnPause) {
                    bool isBreakpoint = OrbisDbg.Ext.ReadByte(regs.r_rip - 1) == 0xCC;
                    ulong breakAddress = isBreakpoint ? regs.r_rip - 1 : regs.r_rip;

                    if (isBreakpoint) {
                        for (int i = 0; i < breakpoints.Count; i++) {
                            if (breakpoints[i].address == breakAddress) {
                                OrbisDbg.Ext.WriteByte(breakAddress, breakpoints[i].instruction);
                                break;
                            }
                        }

                        regs.r_rip -= 1;
                        OrbisDbg.SetRegisters(regs);
                    }

                    if (memoryForm != null) {
                        byte[] mem = OrbisDbg.GetMemory(regs.r_rip, 0x1000);
                        memoryForm.UpdateMemoryView(regs.r_rip, 0x1000, mem);
                    }
                }

                if (registersForm != null)
                    registersForm.UpdateRegisterWindow(regs);

                if(disassemblyForm != null && regs.r_rip != PreviousRip) {
                    if (PreviousRip != 0 && regs.r_rip > PreviousRip && regs.r_rip - PreviousRip < 0xD0) {
                        disassemblyForm.UpdateDisassemblyKeepMemory(regs.r_rip);
                    }
                    else {
                        PreviousRip = regs.r_rip;
                        byte[] memory = OrbisDbg.GetMemory(regs.r_rip, 0x100);
                        disassemblyForm.UpdateDisassembly(regs.r_rip, memory, disassemblyForm.IsShowingBytes());
                    }
                }

                bUpdatedOnPause = true;
            }
        }

        private static void CheckForPausedStateThread(MainForm main) {
            while (true) {
                main.Invoke((MethodInvoker)delegate () { main.UpdateFormsOnPaused(); });
                Thread.Sleep(500);
            }
        }
    }
}
