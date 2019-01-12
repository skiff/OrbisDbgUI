namespace OrbisDbgUI {
    partial class MainForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.MainFormToolStrip = new System.Windows.Forms.ToolStrip();
            this.IPAddressToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.SendPayloadToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.ConnectToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.AttachToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.DetachToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.PlayToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.PauseToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.StepToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.BreakpointToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.ProcessesToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.MemoryToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.RegistersToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.DisassemblyToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.ExitToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.RebootToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.MainFormMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sendPayloadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.attachProcessToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detachProcessToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadELFFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rebootConsoleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.debugToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.continueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pauseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stepInToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.windowsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.breakpointsWindowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.processesWindowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.memoryWindowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registersWindowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.disassemblyWindowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MainFormToolStrip.SuspendLayout();
            this.MainFormMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainFormToolStrip
            // 
            this.MainFormToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.IPAddressToolStripTextBox,
            this.SendPayloadToolStripButton,
            this.ConnectToolStripButton,
            this.AttachToolStripButton,
            this.DetachToolStripButton,
            this.toolStripSeparator1,
            this.PlayToolStripButton,
            this.PauseToolStripButton,
            this.StepToolStripButton,
            this.toolStripSeparator2,
            this.BreakpointToolStripButton,
            this.ProcessesToolStripButton,
            this.MemoryToolStripButton,
            this.RegistersToolStripButton,
            this.DisassemblyToolStripButton,
            this.toolStripSeparator3,
            this.ExitToolStripButton,
            this.RebootToolStripButton});
            this.MainFormToolStrip.Location = new System.Drawing.Point(0, 24);
            this.MainFormToolStrip.Name = "MainFormToolStrip";
            this.MainFormToolStrip.Size = new System.Drawing.Size(1098, 25);
            this.MainFormToolStrip.TabIndex = 0;
            this.MainFormToolStrip.Text = "OrbisToolStrip";
            // 
            // IPAddressToolStripTextBox
            // 
            this.IPAddressToolStripTextBox.Name = "IPAddressToolStripTextBox";
            this.IPAddressToolStripTextBox.Size = new System.Drawing.Size(100, 25);
            this.IPAddressToolStripTextBox.ToolTipText = "IP Address";
            // 
            // SendPayloadToolStripButton
            // 
            this.SendPayloadToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.SendPayloadToolStripButton.Image = global::OrbisDbgUI.Properties.Resources.sendpayload;
            this.SendPayloadToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SendPayloadToolStripButton.Name = "SendPayloadToolStripButton";
            this.SendPayloadToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.SendPayloadToolStripButton.Text = "toolStripButton1";
            this.SendPayloadToolStripButton.ToolTipText = "Send Payload";
            this.SendPayloadToolStripButton.Click += new System.EventHandler(this.SendPayloadToolStripButton_Click);
            // 
            // ConnectToolStripButton
            // 
            this.ConnectToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ConnectToolStripButton.Image = global::OrbisDbgUI.Properties.Resources.connect;
            this.ConnectToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ConnectToolStripButton.Name = "ConnectToolStripButton";
            this.ConnectToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.ConnectToolStripButton.Text = "toolStripButton2";
            this.ConnectToolStripButton.ToolTipText = "Connect";
            this.ConnectToolStripButton.Click += new System.EventHandler(this.ConnectToolStripButton_Click);
            // 
            // AttachToolStripButton
            // 
            this.AttachToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.AttachToolStripButton.Enabled = false;
            this.AttachToolStripButton.Image = global::OrbisDbgUI.Properties.Resources.attach;
            this.AttachToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AttachToolStripButton.Name = "AttachToolStripButton";
            this.AttachToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.AttachToolStripButton.Text = "toolStripButton3";
            this.AttachToolStripButton.ToolTipText = "Attach Process";
            this.AttachToolStripButton.Click += new System.EventHandler(this.AttachToolStripButton_Click);
            // 
            // DetachToolStripButton
            // 
            this.DetachToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.DetachToolStripButton.Enabled = false;
            this.DetachToolStripButton.Image = global::OrbisDbgUI.Properties.Resources.detach;
            this.DetachToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DetachToolStripButton.Name = "DetachToolStripButton";
            this.DetachToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.DetachToolStripButton.Text = "toolStripButton1";
            this.DetachToolStripButton.ToolTipText = "Detach Process";
            this.DetachToolStripButton.Click += new System.EventHandler(this.DetachToolStripButton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // PlayToolStripButton
            // 
            this.PlayToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.PlayToolStripButton.Enabled = false;
            this.PlayToolStripButton.Image = global::OrbisDbgUI.Properties.Resources.play;
            this.PlayToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.PlayToolStripButton.Name = "PlayToolStripButton";
            this.PlayToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.PlayToolStripButton.Text = "toolStripButton4";
            this.PlayToolStripButton.ToolTipText = "Continue";
            this.PlayToolStripButton.Click += new System.EventHandler(this.PlayToolStripButton_Click);
            // 
            // PauseToolStripButton
            // 
            this.PauseToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.PauseToolStripButton.Enabled = false;
            this.PauseToolStripButton.Image = global::OrbisDbgUI.Properties.Resources.pause;
            this.PauseToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.PauseToolStripButton.Name = "PauseToolStripButton";
            this.PauseToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.PauseToolStripButton.Text = "toolStripButton5";
            this.PauseToolStripButton.ToolTipText = "Pause";
            this.PauseToolStripButton.Click += new System.EventHandler(this.PauseToolStripButton_Click);
            // 
            // StepToolStripButton
            // 
            this.StepToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.StepToolStripButton.Enabled = false;
            this.StepToolStripButton.Image = global::OrbisDbgUI.Properties.Resources.step;
            this.StepToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.StepToolStripButton.Name = "StepToolStripButton";
            this.StepToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.StepToolStripButton.Text = "toolStripButton6";
            this.StepToolStripButton.ToolTipText = "Step In";
            this.StepToolStripButton.Click += new System.EventHandler(this.StepToolStripButton_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // BreakpointToolStripButton
            // 
            this.BreakpointToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BreakpointToolStripButton.Enabled = false;
            this.BreakpointToolStripButton.Image = global::OrbisDbgUI.Properties.Resources.breakpoint;
            this.BreakpointToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BreakpointToolStripButton.Name = "BreakpointToolStripButton";
            this.BreakpointToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.BreakpointToolStripButton.Text = "toolStripButton7";
            this.BreakpointToolStripButton.ToolTipText = "Breakpoints";
            this.BreakpointToolStripButton.Click += new System.EventHandler(this.BreakpointToolStripButton_Click);
            // 
            // ProcessesToolStripButton
            // 
            this.ProcessesToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ProcessesToolStripButton.Enabled = false;
            this.ProcessesToolStripButton.Image = global::OrbisDbgUI.Properties.Resources.processes;
            this.ProcessesToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ProcessesToolStripButton.Name = "ProcessesToolStripButton";
            this.ProcessesToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.ProcessesToolStripButton.Text = "toolStripButton8";
            this.ProcessesToolStripButton.ToolTipText = "List Processes";
            this.ProcessesToolStripButton.Click += new System.EventHandler(this.ProcessesToolStripButton_Click);
            // 
            // MemoryToolStripButton
            // 
            this.MemoryToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.MemoryToolStripButton.Enabled = false;
            this.MemoryToolStripButton.Image = global::OrbisDbgUI.Properties.Resources.memorywindow;
            this.MemoryToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.MemoryToolStripButton.Name = "MemoryToolStripButton";
            this.MemoryToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.MemoryToolStripButton.Text = "toolStripButton9";
            this.MemoryToolStripButton.ToolTipText = "Memory Window";
            this.MemoryToolStripButton.Click += new System.EventHandler(this.MemoryToolStripButton_Click);
            // 
            // RegistersToolStripButton
            // 
            this.RegistersToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.RegistersToolStripButton.Enabled = false;
            this.RegistersToolStripButton.Image = global::OrbisDbgUI.Properties.Resources.registers;
            this.RegistersToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.RegistersToolStripButton.Name = "RegistersToolStripButton";
            this.RegistersToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.RegistersToolStripButton.Text = "toolStripButton10";
            this.RegistersToolStripButton.ToolTipText = "Registers Window";
            this.RegistersToolStripButton.Click += new System.EventHandler(this.RegistersToolStripButton_Click);
            // 
            // DisassemblyToolStripButton
            // 
            this.DisassemblyToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.DisassemblyToolStripButton.Enabled = false;
            this.DisassemblyToolStripButton.Image = global::OrbisDbgUI.Properties.Resources.disassembly;
            this.DisassemblyToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DisassemblyToolStripButton.Name = "DisassemblyToolStripButton";
            this.DisassemblyToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.DisassemblyToolStripButton.Text = "toolStripButton11";
            this.DisassemblyToolStripButton.ToolTipText = "Disassembly Window";
            this.DisassemblyToolStripButton.Click += new System.EventHandler(this.DisassemblyToolStripButton_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // ExitToolStripButton
            // 
            this.ExitToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ExitToolStripButton.Enabled = false;
            this.ExitToolStripButton.Image = global::OrbisDbgUI.Properties.Resources.exit_game;
            this.ExitToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ExitToolStripButton.Name = "ExitToolStripButton";
            this.ExitToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.ExitToolStripButton.Text = "toolStripButton12";
            this.ExitToolStripButton.ToolTipText = "Exit Game";
            this.ExitToolStripButton.Click += new System.EventHandler(this.ExitToolStripButton_Click);
            // 
            // RebootToolStripButton
            // 
            this.RebootToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.RebootToolStripButton.Image = global::OrbisDbgUI.Properties.Resources.reboot;
            this.RebootToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.RebootToolStripButton.Name = "RebootToolStripButton";
            this.RebootToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.RebootToolStripButton.Text = "toolStripButton13";
            this.RebootToolStripButton.ToolTipText = "Reboot Console";
            this.RebootToolStripButton.Click += new System.EventHandler(this.RebootToolStripButton_Click);
            // 
            // MainFormMenuStrip
            // 
            this.MainFormMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.debugToolStripMenuItem,
            this.windowsToolStripMenuItem});
            this.MainFormMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MainFormMenuStrip.Name = "MainFormMenuStrip";
            this.MainFormMenuStrip.Size = new System.Drawing.Size(1098, 24);
            this.MainFormMenuStrip.TabIndex = 1;
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sendPayloadToolStripMenuItem,
            this.connectToolStripMenuItem,
            this.attachProcessToolStripMenuItem,
            this.detachProcessToolStripMenuItem,
            this.loadELFFileToolStripMenuItem,
            this.quitGameToolStripMenuItem,
            this.rebootConsoleToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // sendPayloadToolStripMenuItem
            // 
            this.sendPayloadToolStripMenuItem.Name = "sendPayloadToolStripMenuItem";
            this.sendPayloadToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sendPayloadToolStripMenuItem.Text = "Send Payload";
            this.sendPayloadToolStripMenuItem.Click += new System.EventHandler(this.sendPayloadToolStripMenuItem_Click);
            // 
            // connectToolStripMenuItem
            // 
            this.connectToolStripMenuItem.Name = "connectToolStripMenuItem";
            this.connectToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.connectToolStripMenuItem.Text = "Connect";
            this.connectToolStripMenuItem.Click += new System.EventHandler(this.connectToolStripMenuItem_Click);
            // 
            // attachProcessToolStripMenuItem
            // 
            this.attachProcessToolStripMenuItem.Enabled = false;
            this.attachProcessToolStripMenuItem.Name = "attachProcessToolStripMenuItem";
            this.attachProcessToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.attachProcessToolStripMenuItem.Text = "Attach Process";
            this.attachProcessToolStripMenuItem.Click += new System.EventHandler(this.attachProcessToolStripMenuItem_Click);
            // 
            // detachProcessToolStripMenuItem
            // 
            this.detachProcessToolStripMenuItem.Enabled = false;
            this.detachProcessToolStripMenuItem.Name = "detachProcessToolStripMenuItem";
            this.detachProcessToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.detachProcessToolStripMenuItem.Text = "Detach Process";
            this.detachProcessToolStripMenuItem.Click += new System.EventHandler(this.detachProcessToolStripMenuItem_Click);
            // 
            // loadELFFileToolStripMenuItem
            // 
            this.loadELFFileToolStripMenuItem.Enabled = false;
            this.loadELFFileToolStripMenuItem.Name = "loadELFFileToolStripMenuItem";
            this.loadELFFileToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.loadELFFileToolStripMenuItem.Text = "Load ELF File";
            this.loadELFFileToolStripMenuItem.Click += new System.EventHandler(this.loadELFFileToolStripMenuItem_Click);
            // 
            // quitGameToolStripMenuItem
            // 
            this.quitGameToolStripMenuItem.Enabled = false;
            this.quitGameToolStripMenuItem.Name = "quitGameToolStripMenuItem";
            this.quitGameToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.quitGameToolStripMenuItem.Text = "Quit Game";
            this.quitGameToolStripMenuItem.Click += new System.EventHandler(this.quitGameToolStripMenuItem_Click);
            // 
            // rebootConsoleToolStripMenuItem
            // 
            this.rebootConsoleToolStripMenuItem.Name = "rebootConsoleToolStripMenuItem";
            this.rebootConsoleToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.rebootConsoleToolStripMenuItem.Text = "Reboot Console";
            this.rebootConsoleToolStripMenuItem.Click += new System.EventHandler(this.rebootConsoleToolStripMenuItem_Click);
            // 
            // debugToolStripMenuItem
            // 
            this.debugToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.continueToolStripMenuItem,
            this.pauseToolStripMenuItem,
            this.stepInToolStripMenuItem});
            this.debugToolStripMenuItem.Name = "debugToolStripMenuItem";
            this.debugToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.debugToolStripMenuItem.Text = "Debug";
            // 
            // continueToolStripMenuItem
            // 
            this.continueToolStripMenuItem.Enabled = false;
            this.continueToolStripMenuItem.Name = "continueToolStripMenuItem";
            this.continueToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.continueToolStripMenuItem.Text = "Continue";
            this.continueToolStripMenuItem.Click += new System.EventHandler(this.continueToolStripMenuItem_Click);
            // 
            // pauseToolStripMenuItem
            // 
            this.pauseToolStripMenuItem.Enabled = false;
            this.pauseToolStripMenuItem.Name = "pauseToolStripMenuItem";
            this.pauseToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.pauseToolStripMenuItem.Text = "Pause";
            this.pauseToolStripMenuItem.Click += new System.EventHandler(this.pauseToolStripMenuItem_Click);
            // 
            // stepInToolStripMenuItem
            // 
            this.stepInToolStripMenuItem.Enabled = false;
            this.stepInToolStripMenuItem.Name = "stepInToolStripMenuItem";
            this.stepInToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.stepInToolStripMenuItem.Text = "Step In";
            this.stepInToolStripMenuItem.Click += new System.EventHandler(this.stepInToolStripMenuItem_Click);
            // 
            // windowsToolStripMenuItem
            // 
            this.windowsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.breakpointsWindowToolStripMenuItem,
            this.processesWindowToolStripMenuItem,
            this.memoryWindowToolStripMenuItem,
            this.registersWindowToolStripMenuItem,
            this.disassemblyWindowToolStripMenuItem});
            this.windowsToolStripMenuItem.Name = "windowsToolStripMenuItem";
            this.windowsToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.windowsToolStripMenuItem.Text = "Windows";
            // 
            // breakpointsWindowToolStripMenuItem
            // 
            this.breakpointsWindowToolStripMenuItem.Enabled = false;
            this.breakpointsWindowToolStripMenuItem.Name = "breakpointsWindowToolStripMenuItem";
            this.breakpointsWindowToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.breakpointsWindowToolStripMenuItem.Text = "Breakpoints Window";
            this.breakpointsWindowToolStripMenuItem.Click += new System.EventHandler(this.breakpointsWindowToolStripMenuItem_Click);
            // 
            // processesWindowToolStripMenuItem
            // 
            this.processesWindowToolStripMenuItem.Enabled = false;
            this.processesWindowToolStripMenuItem.Name = "processesWindowToolStripMenuItem";
            this.processesWindowToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.processesWindowToolStripMenuItem.Text = "Processes Window";
            this.processesWindowToolStripMenuItem.Click += new System.EventHandler(this.processesWindowToolStripMenuItem_Click);
            // 
            // memoryWindowToolStripMenuItem
            // 
            this.memoryWindowToolStripMenuItem.Enabled = false;
            this.memoryWindowToolStripMenuItem.Name = "memoryWindowToolStripMenuItem";
            this.memoryWindowToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.memoryWindowToolStripMenuItem.Text = "Memory Window";
            this.memoryWindowToolStripMenuItem.Click += new System.EventHandler(this.memoryWindowToolStripMenuItem_Click);
            // 
            // registersWindowToolStripMenuItem
            // 
            this.registersWindowToolStripMenuItem.Enabled = false;
            this.registersWindowToolStripMenuItem.Name = "registersWindowToolStripMenuItem";
            this.registersWindowToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.registersWindowToolStripMenuItem.Text = "Registers Window";
            this.registersWindowToolStripMenuItem.Click += new System.EventHandler(this.registersWindowToolStripMenuItem_Click);
            // 
            // disassemblyWindowToolStripMenuItem
            // 
            this.disassemblyWindowToolStripMenuItem.Enabled = false;
            this.disassemblyWindowToolStripMenuItem.Name = "disassemblyWindowToolStripMenuItem";
            this.disassemblyWindowToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.disassemblyWindowToolStripMenuItem.Text = "Disassembly Window";
            this.disassemblyWindowToolStripMenuItem.Click += new System.EventHandler(this.disassemblyWindowToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1098, 724);
            this.Controls.Add(this.MainFormToolStrip);
            this.Controls.Add(this.MainFormMenuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.MainFormMenuStrip;
            this.Name = "MainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OrbisDbgUI";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.MainFormToolStrip.ResumeLayout(false);
            this.MainFormToolStrip.PerformLayout();
            this.MainFormMenuStrip.ResumeLayout(false);
            this.MainFormMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip MainFormToolStrip;
        private System.Windows.Forms.ToolStripButton SendPayloadToolStripButton;
        private System.Windows.Forms.ToolStripTextBox IPAddressToolStripTextBox;
        private System.Windows.Forms.ToolStripButton ConnectToolStripButton;
        private System.Windows.Forms.ToolStripButton AttachToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton PlayToolStripButton;
        private System.Windows.Forms.ToolStripButton PauseToolStripButton;
        private System.Windows.Forms.ToolStripButton StepToolStripButton;
        private System.Windows.Forms.ToolStripButton BreakpointToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton ProcessesToolStripButton;
        private System.Windows.Forms.ToolStripButton MemoryToolStripButton;
        private System.Windows.Forms.ToolStripButton RegistersToolStripButton;
        private System.Windows.Forms.ToolStripButton DisassemblyToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton ExitToolStripButton;
        private System.Windows.Forms.ToolStripButton RebootToolStripButton;
        private System.Windows.Forms.ToolStripButton DetachToolStripButton;
        private System.Windows.Forms.MenuStrip MainFormMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem debugToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem windowsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sendPayloadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem connectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem attachProcessToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem detachProcessToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadELFFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem continueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pauseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stepInToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem breakpointsWindowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem processesWindowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem memoryWindowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registersWindowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem disassemblyWindowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rebootConsoleToolStripMenuItem;
    }
}

