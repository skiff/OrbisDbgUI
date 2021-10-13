using System;
using System.Drawing;
using System.Windows.Forms;

namespace OrbisDbgUI {
    public partial class RegistersForm : Form {
        private MainForm mainForm;
        private string registerValue;

        public RegistersForm(MainForm mainForm) {
            InitializeComponent();
            this.mainForm = mainForm;
        }

        private void RegistersForm_FormClosed(object sender, FormClosedEventArgs e) {
            mainForm.registersForm = null;
        }

        public void UpdateRegisterWindow(OrbisDbg.registers regs) {
            RAXRegisterValue.ReadOnly = false;
            RAXRegisterValue.ForeColor = (RAXRegisterValue.Text.Equals("0x" + regs.r_rax.ToString("X16"))) ? Color.Black : Color.Red;
            RAXRegisterValue.Text = String.Format("0x{0}", regs.r_rax.ToString("X16"));
            RBXRegisterValue.ReadOnly = false;
            RBXRegisterValue.ForeColor = (RBXRegisterValue.Text.Equals("0x" + regs.r_rbx.ToString("X16"))) ? Color.Black : Color.Red;
            RBXRegisterValue.Text = String.Format("0x{0}", regs.r_rbx.ToString("X16"));
            RDIRegisterValue.ReadOnly = false;
            RDIRegisterValue.ForeColor = (RDIRegisterValue.Text.Equals("0x" + regs.r_rdi.ToString("X16"))) ? Color.Black : Color.Red;
            RDIRegisterValue.Text = String.Format("0x{0}", regs.r_rdi.ToString("X16"));
            RSIRegisterValue.ReadOnly = false;
            RSIRegisterValue.ForeColor = (RSIRegisterValue.Text.Equals("0x" + regs.r_rsi.ToString("X16"))) ? Color.Black : Color.Red;
            RSIRegisterValue.Text = String.Format("0x{0}", regs.r_rsi.ToString("X16"));
            RDXRegisterValue.ReadOnly = false;
            RDXRegisterValue.ForeColor = (RDXRegisterValue.Text.Equals("0x" + regs.r_rdx.ToString("X16"))) ? Color.Black : Color.Red;
            RDXRegisterValue.Text = String.Format("0x{0}", regs.r_rdx.ToString("X16"));
            RCXRegisterValue.ReadOnly = false;
            RCXRegisterValue.ForeColor = (RCXRegisterValue.Text.Equals("0x" + regs.r_rcx.ToString("X16"))) ? Color.Black : Color.Red;
            RCXRegisterValue.Text = String.Format("0x{0}", regs.r_rcx.ToString("X16"));
            R8RegisterValue.ReadOnly = false;
            R8RegisterValue.ForeColor = (R8RegisterValue.Text.Equals("0x" + regs.r_r8.ToString("X16"))) ? Color.Black : Color.Red;
            R8RegisterValue.Text = String.Format("0x{0}", regs.r_r8.ToString("X16"));
            R9RegisterValue.ReadOnly = false;
            R9RegisterValue.ForeColor = (R9RegisterValue.Text.Equals("0x" + regs.r_r9.ToString("X16"))) ? Color.Black : Color.Red;
            R9RegisterValue.Text = String.Format("0x{0}", regs.r_r9.ToString("X16"));
            R10RegisterValue.ReadOnly = false;
            R10RegisterValue.ForeColor = (R10RegisterValue.Text.Equals("0x" + regs.r_r10.ToString("X16"))) ? Color.Black : Color.Red;
            R10RegisterValue.Text = String.Format("0x{0}", regs.r_r10.ToString("X16"));
            R11RegisterValue.ReadOnly = false;
            R11RegisterValue.ForeColor = (R11RegisterValue.Text.Equals("0x" + regs.r_r11.ToString("X16"))) ? Color.Black : Color.Red;
            R11RegisterValue.Text = String.Format("0x{0}", regs.r_r11.ToString("X16"));
            R12RegisterValue.ReadOnly = false;
            R12RegisterValue.ForeColor = (R12RegisterValue.Text.Equals("0x" + regs.r_r12.ToString("X16"))) ? Color.Black : Color.Red;
            R12RegisterValue.Text = String.Format("0x{0}", regs.r_r12.ToString("X16"));
            R13RegisterValue.ReadOnly = false;
            R13RegisterValue.ForeColor = (R13RegisterValue.Text.Equals("0x" + regs.r_r13.ToString("X16"))) ? Color.Black : Color.Red;
            R13RegisterValue.Text = String.Format("0x{0}", regs.r_r13.ToString("X16"));
            R14RegisterValue.ReadOnly = false;
            R14RegisterValue.ForeColor = (R14RegisterValue.Text.Equals("0x" + regs.r_r14.ToString("X16"))) ? Color.Black : Color.Red;
            R14RegisterValue.Text = String.Format("0x{0}", regs.r_r14.ToString("X16"));
            R15RegisterValue.ReadOnly = false;
            R15RegisterValue.ForeColor = (R15RegisterValue.Text.Equals("0x" + regs.r_r15.ToString("X16"))) ? Color.Black : Color.Red;
            R15RegisterValue.Text = String.Format("0x{0}", regs.r_r15.ToString("X16"));
            RSPRegisterValue.ReadOnly = false;
            RSPRegisterValue.ForeColor = (RSPRegisterValue.Text.Equals("0x" + regs.r_rsp.ToString("X16"))) ? Color.Black : Color.Red;
            RSPRegisterValue.Text = String.Format("0x{0}", regs.r_rsp.ToString("X16"));
            RBPRegisterValue.ReadOnly = false;
            RBPRegisterValue.ForeColor = (RBPRegisterValue.Text.Equals("0x" + regs.r_rbp.ToString("X16"))) ? Color.Black : Color.Red;
            RBPRegisterValue.Text = String.Format("0x{0}", regs.r_rbp.ToString("X16"));
            RIPRegisterValue.ReadOnly = false;
            RIPRegisterValue.ForeColor = (RIPRegisterValue.Text.Equals("0x" + regs.r_rip.ToString("X16"))) ? Color.Black : Color.Red;
            RIPRegisterValue.Text = String.Format("0x{0}", regs.r_rip.ToString("X16"));
            TrapRegisterValue.ReadOnly = false;
            TrapRegisterValue.ForeColor = (TrapRegisterValue.Text.Equals("0x" + regs.r_trapno.ToString("X16"))) ? Color.Black : Color.Red;
            TrapRegisterValue.Text = String.Format("0x{0}", regs.r_trapno.ToString("X16"));
            ErrRegisterValue.ReadOnly = false;
            ErrRegisterValue.ForeColor = (ErrRegisterValue.Text.Equals("0x" + regs.r_err.ToString("X16"))) ? Color.Black : Color.Red;
            ErrRegisterValue.Text = String.Format("0x{0}", regs.r_err.ToString("X16"));
            rFlagRegisterValue.ReadOnly = false;
            rFlagRegisterValue.ForeColor = (rFlagRegisterValue.Text.Equals("0x" + regs.r_rflags.ToString("X16"))) ? Color.Black : Color.Red;
            rFlagRegisterValue.Text = String.Format("0x{0}", regs.r_rflags.ToString("X16"));
        }

        public void FreezeRegisters() {
            RAXRegisterValue.ReadOnly = false;
            RAXRegisterValue.ForeColor = Color.Black;
            RAXRegisterValue.Text = "0x0000000000000000";
            RBXRegisterValue.ReadOnly = false;
            RBXRegisterValue.ForeColor = Color.Black;
            RBXRegisterValue.Text = "0x0000000000000000";
            RDIRegisterValue.ReadOnly = false;
            RDIRegisterValue.ForeColor = Color.Black;
            RDIRegisterValue.Text = "0x0000000000000000";
            RSIRegisterValue.ReadOnly = false;
            RSIRegisterValue.ForeColor = Color.Black;
            RSIRegisterValue.Text = "0x0000000000000000";
            RDXRegisterValue.ReadOnly = false;
            RDXRegisterValue.ForeColor = Color.Black;
            RDXRegisterValue.Text = "0x0000000000000000";
            RCXRegisterValue.ReadOnly = false;
            RCXRegisterValue.ForeColor = Color.Black;
            RCXRegisterValue.Text = "0x0000000000000000";
            R8RegisterValue.ReadOnly = false;
            R8RegisterValue.ForeColor = Color.Black;
            R8RegisterValue.Text = "0x0000000000000000";
            R9RegisterValue.ReadOnly = false;
            R9RegisterValue.ForeColor = Color.Black;
            R9RegisterValue.Text = "0x0000000000000000";
            R10RegisterValue.ReadOnly = false;
            R10RegisterValue.ForeColor = Color.Black;
            R10RegisterValue.Text = "0x0000000000000000";
            R11RegisterValue.ReadOnly = false;
            R11RegisterValue.ForeColor = Color.Black;
            R11RegisterValue.Text = "0x0000000000000000";
            R12RegisterValue.ReadOnly = false;
            R12RegisterValue.ForeColor = Color.Black;
            R12RegisterValue.Text = "0x0000000000000000";
            R13RegisterValue.ReadOnly = false;
            R13RegisterValue.ForeColor = Color.Black;
            R13RegisterValue.Text = "0x0000000000000000";
            R14RegisterValue.ReadOnly = false;
            R14RegisterValue.ForeColor = Color.Black;
            R14RegisterValue.Text = "0x0000000000000000";
            R15RegisterValue.ReadOnly = false;
            R15RegisterValue.ForeColor = Color.Black;
            R15RegisterValue.Text = "0x0000000000000000";
            RSPRegisterValue.ReadOnly = false;
            RSPRegisterValue.ForeColor = Color.Black;
            RSPRegisterValue.Text = "0x0000000000000000";
            RBPRegisterValue.ReadOnly = false;
            RBPRegisterValue.ForeColor = Color.Black;
            RBPRegisterValue.Text = "0x0000000000000000";
            RIPRegisterValue.ReadOnly = false;
            RIPRegisterValue.ForeColor = Color.Black;
            RIPRegisterValue.Text = "0x0000000000000000";
            TrapRegisterValue.ReadOnly = false;
            TrapRegisterValue.ForeColor = Color.Black;
            TrapRegisterValue.Text = "0x0000000000000000";
            ErrRegisterValue.ReadOnly = false;
            ErrRegisterValue.ForeColor = Color.Black;
            ErrRegisterValue.Text = "0x0000000000000000";
            rFlagRegisterValue.ReadOnly = false;
            rFlagRegisterValue.ForeColor = Color.Black;
            rFlagRegisterValue.Text = "0x0000000000000000";
        }

        public OrbisDbg.registers GetRegisters() {
            OrbisDbg.registers result = OrbisDbg.GetRegisters();
            result.r_rax = Convert.ToUInt64(RAXRegisterValue.Text, 16);
            result.r_rbx = Convert.ToUInt64(RBXRegisterValue.Text, 16);
            result.r_rdi = Convert.ToUInt64(RDIRegisterValue.Text, 16);
            result.r_rsi = Convert.ToUInt64(RSIRegisterValue.Text, 16);
            result.r_rdx = Convert.ToUInt64(RDXRegisterValue.Text, 16);
            result.r_rcx = Convert.ToUInt64(RCXRegisterValue.Text, 16);
            result.r_r8 = Convert.ToUInt64(R8RegisterValue.Text, 16);
            result.r_r9 = Convert.ToUInt64(R9RegisterValue.Text, 16);
            result.r_r10 = Convert.ToUInt64(R10RegisterValue.Text, 16);
            result.r_r11 = Convert.ToUInt64(R11RegisterValue.Text, 16);
            result.r_r12 = Convert.ToUInt64(R12RegisterValue.Text, 16);
            result.r_r13 = Convert.ToUInt64(R13RegisterValue.Text, 16);
            result.r_r14 = Convert.ToUInt64(R14RegisterValue.Text, 16);
            result.r_r15 = Convert.ToUInt64(R15RegisterValue.Text, 16);
            result.r_rsp = Convert.ToUInt64(RSPRegisterValue.Text, 16);
            result.r_rbp = Convert.ToUInt64(RBPRegisterValue.Text, 16);
            result.r_rip = Convert.ToUInt64(RIPRegisterValue.Text, 16);
            return result;
        }

        private void RefreshRegistersButton_Click(object sender, EventArgs e) {
            if (OrbisDbg.IsProcessPaused())
                UpdateRegisterWindow(OrbisDbg.GetRegisters());
            else
                MessageBox.Show("The process must be paused before you can get/set registers", "Error Getting Registers");
        }

        private void SetRegistersButton_Click(object sender, EventArgs e) {
            if (OrbisDbg.IsProcessPaused())
                OrbisDbg.SetRegisters(GetRegisters());
            else
                MessageBox.Show("The process must be paused before you can get/set registers", "Error Getting Registers");
        }

        private void Register_DoubleClick(object sender, EventArgs e) {
            if (OrbisDbg.IsProcessPaused()) {
                TextBox textBox = sender as TextBox;
                registerValue = textBox.Text;
                textBox.ReadOnly = false;
                textBox.ForeColor = Color.Red;
            }
            else {
                MessageBox.Show("The process must be paused before you can get/set registers", "Error Getting Registers");
            }
        }

        private void Register_Leave(object sender, EventArgs e) {
            try {
                TextBox textBox = sender as TextBox;
                textBox.Text = "0x" + Convert.ToUInt64(textBox.Text.StartsWith("0x", StringComparison.CurrentCultureIgnoreCase) ? textBox.Text.Substring(2) : textBox.Text, 16).ToString("X16");
            }
            catch {
                TextBox textBox = sender as TextBox;
                textBox.Text = registerValue;
            }
        }

        private void Register_KeyDown(object sender, KeyEventArgs e) {
            try {
                bool flag = e.KeyCode == Keys.Return;
                if (flag) {
                    TextBox textBox = sender as TextBox;
                    textBox.Text = "0x" + Convert.ToUInt64(textBox.Text.StartsWith("0x", StringComparison.CurrentCultureIgnoreCase) ? textBox.Text.Substring(2) : textBox.Text, 16).ToString("X16");
                }
            }
            catch {
                TextBox textBox = sender as TextBox;
                textBox.Text = registerValue;
            }
        }
    }
}
