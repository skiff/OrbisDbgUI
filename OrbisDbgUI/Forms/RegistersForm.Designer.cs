namespace OrbisDbgUI {
    partial class RegistersForm {
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
            this.RegistersToolStrip = new System.Windows.Forms.ToolStrip();
            this.RefreshRegistersButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.SetRegistersButton = new System.Windows.Forms.ToolStripButton();
            this.RAXRegisterLabel = new System.Windows.Forms.Label();
            this.RAXRegisterValue = new System.Windows.Forms.TextBox();
            this.RDIRegisterValue = new System.Windows.Forms.TextBox();
            this.RDIRegisterLabel = new System.Windows.Forms.Label();
            this.RSIRegisterValue = new System.Windows.Forms.TextBox();
            this.RSIRegisterLabel = new System.Windows.Forms.Label();
            this.RDXRegisterValue = new System.Windows.Forms.TextBox();
            this.RDXRegisterLabel = new System.Windows.Forms.Label();
            this.RCXRegisterValue = new System.Windows.Forms.TextBox();
            this.RCXRegisterLabel = new System.Windows.Forms.Label();
            this.R8RegisterValue = new System.Windows.Forms.TextBox();
            this.R8RegisterLabel = new System.Windows.Forms.Label();
            this.R9RegisterValue = new System.Windows.Forms.TextBox();
            this.R9RegisterLabel = new System.Windows.Forms.Label();
            this.R10RegisterValue = new System.Windows.Forms.TextBox();
            this.R10RegisterLabel = new System.Windows.Forms.Label();
            this.R11RegisterValue = new System.Windows.Forms.TextBox();
            this.R11RegisterLabel = new System.Windows.Forms.Label();
            this.R12RegisterValue = new System.Windows.Forms.TextBox();
            this.R12RegisterLabel = new System.Windows.Forms.Label();
            this.R13RegisterValue = new System.Windows.Forms.TextBox();
            this.R13RegisterLabel = new System.Windows.Forms.Label();
            this.R14RegisterValue = new System.Windows.Forms.TextBox();
            this.R14RegisterLabel = new System.Windows.Forms.Label();
            this.R15RegisterValue = new System.Windows.Forms.TextBox();
            this.R15RegisterLabel = new System.Windows.Forms.Label();
            this.RSPRegisterValue = new System.Windows.Forms.TextBox();
            this.RSPRegisterLabel = new System.Windows.Forms.Label();
            this.RBPRegisterValue = new System.Windows.Forms.TextBox();
            this.RBPRegisterLabel = new System.Windows.Forms.Label();
            this.RIPRegisterValue = new System.Windows.Forms.TextBox();
            this.RIPRegisterLabel = new System.Windows.Forms.Label();
            this.TrapRegisterValue = new System.Windows.Forms.TextBox();
            this.TrapRegisterLabel = new System.Windows.Forms.Label();
            this.ErrRegisterValue = new System.Windows.Forms.TextBox();
            this.ErrRegisterLabel = new System.Windows.Forms.Label();
            this.rFlagRegisterValue = new System.Windows.Forms.TextBox();
            this.rFlagRegisterLabel = new System.Windows.Forms.Label();
            this.RBXRegisterValue = new System.Windows.Forms.TextBox();
            this.RBXRegisterLabel = new System.Windows.Forms.Label();
            this.RegistersToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // RegistersToolStrip
            // 
            this.RegistersToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.RegistersToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RefreshRegistersButton,
            this.toolStripSeparator1,
            this.SetRegistersButton});
            this.RegistersToolStrip.Location = new System.Drawing.Point(0, 0);
            this.RegistersToolStrip.Name = "RegistersToolStrip";
            this.RegistersToolStrip.Size = new System.Drawing.Size(651, 27);
            this.RegistersToolStrip.TabIndex = 0;
            this.RegistersToolStrip.Text = "toolStrip1";
            // 
            // RefreshRegistersButton
            // 
            this.RefreshRegistersButton.Image = global::OrbisDbgUI.Properties.Resources.refresh1;
            this.RefreshRegistersButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.RefreshRegistersButton.Name = "RefreshRegistersButton";
            this.RefreshRegistersButton.Size = new System.Drawing.Size(146, 24);
            this.RefreshRegistersButton.Text = "Refresh Registers";
            this.RefreshRegistersButton.Click += new System.EventHandler(this.RefreshRegistersButton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // SetRegistersButton
            // 
            this.SetRegistersButton.Image = global::OrbisDbgUI.Properties.Resources.registers_check;
            this.SetRegistersButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SetRegistersButton.Name = "SetRegistersButton";
            this.SetRegistersButton.Size = new System.Drawing.Size(118, 24);
            this.SetRegistersButton.Text = "Set Registers";
            this.SetRegistersButton.Click += new System.EventHandler(this.SetRegistersButton_Click);
            // 
            // RAXRegisterLabel
            // 
            this.RAXRegisterLabel.AutoSize = true;
            this.RAXRegisterLabel.Location = new System.Drawing.Point(-1, 31);
            this.RAXRegisterLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.RAXRegisterLabel.Name = "RAXRegisterLabel";
            this.RAXRegisterLabel.Size = new System.Drawing.Size(40, 17);
            this.RAXRegisterLabel.TabIndex = 1;
            this.RAXRegisterLabel.Text = "RAX:";
            // 
            // RAXRegisterValue
            // 
            this.RAXRegisterValue.BackColor = System.Drawing.SystemColors.Control;
            this.RAXRegisterValue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RAXRegisterValue.Location = new System.Drawing.Point(41, 31);
            this.RAXRegisterValue.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RAXRegisterValue.Name = "RAXRegisterValue";
            this.RAXRegisterValue.ReadOnly = true;
            this.RAXRegisterValue.Size = new System.Drawing.Size(153, 15);
            this.RAXRegisterValue.TabIndex = 2;
            this.RAXRegisterValue.Text = "0x0000000000000000";
            this.RAXRegisterValue.DoubleClick += new System.EventHandler(this.Register_DoubleClick);
            this.RAXRegisterValue.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Register_KeyDown);
            this.RAXRegisterValue.Leave += new System.EventHandler(this.Register_Leave);
            // 
            // RDIRegisterValue
            // 
            this.RDIRegisterValue.BackColor = System.Drawing.SystemColors.Control;
            this.RDIRegisterValue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RDIRegisterValue.Location = new System.Drawing.Point(41, 74);
            this.RDIRegisterValue.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RDIRegisterValue.Name = "RDIRegisterValue";
            this.RDIRegisterValue.ReadOnly = true;
            this.RDIRegisterValue.Size = new System.Drawing.Size(153, 15);
            this.RDIRegisterValue.TabIndex = 4;
            this.RDIRegisterValue.Text = "0x0000000000000000";
            this.RDIRegisterValue.DoubleClick += new System.EventHandler(this.Register_DoubleClick);
            this.RDIRegisterValue.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Register_KeyDown);
            this.RDIRegisterValue.Leave += new System.EventHandler(this.Register_Leave);
            // 
            // RDIRegisterLabel
            // 
            this.RDIRegisterLabel.AutoSize = true;
            this.RDIRegisterLabel.Location = new System.Drawing.Point(-1, 74);
            this.RDIRegisterLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.RDIRegisterLabel.Name = "RDIRegisterLabel";
            this.RDIRegisterLabel.Size = new System.Drawing.Size(35, 17);
            this.RDIRegisterLabel.TabIndex = 3;
            this.RDIRegisterLabel.Text = "RDI:";
            // 
            // RSIRegisterValue
            // 
            this.RSIRegisterValue.BackColor = System.Drawing.SystemColors.Control;
            this.RSIRegisterValue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RSIRegisterValue.Location = new System.Drawing.Point(41, 97);
            this.RSIRegisterValue.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RSIRegisterValue.Name = "RSIRegisterValue";
            this.RSIRegisterValue.ReadOnly = true;
            this.RSIRegisterValue.Size = new System.Drawing.Size(153, 15);
            this.RSIRegisterValue.TabIndex = 6;
            this.RSIRegisterValue.Text = "0x0000000000000000";
            this.RSIRegisterValue.DoubleClick += new System.EventHandler(this.Register_DoubleClick);
            this.RSIRegisterValue.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Register_KeyDown);
            this.RSIRegisterValue.Leave += new System.EventHandler(this.Register_Leave);
            // 
            // RSIRegisterLabel
            // 
            this.RSIRegisterLabel.AutoSize = true;
            this.RSIRegisterLabel.Location = new System.Drawing.Point(-1, 97);
            this.RSIRegisterLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.RSIRegisterLabel.Name = "RSIRegisterLabel";
            this.RSIRegisterLabel.Size = new System.Drawing.Size(34, 17);
            this.RSIRegisterLabel.TabIndex = 5;
            this.RSIRegisterLabel.Text = "RSI:";
            // 
            // RDXRegisterValue
            // 
            this.RDXRegisterValue.BackColor = System.Drawing.SystemColors.Control;
            this.RDXRegisterValue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RDXRegisterValue.Location = new System.Drawing.Point(41, 120);
            this.RDXRegisterValue.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RDXRegisterValue.Name = "RDXRegisterValue";
            this.RDXRegisterValue.ReadOnly = true;
            this.RDXRegisterValue.Size = new System.Drawing.Size(153, 15);
            this.RDXRegisterValue.TabIndex = 8;
            this.RDXRegisterValue.Text = "0x0000000000000000";
            this.RDXRegisterValue.DoubleClick += new System.EventHandler(this.Register_DoubleClick);
            this.RDXRegisterValue.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Register_KeyDown);
            this.RDXRegisterValue.Leave += new System.EventHandler(this.Register_Leave);
            // 
            // RDXRegisterLabel
            // 
            this.RDXRegisterLabel.AutoSize = true;
            this.RDXRegisterLabel.Location = new System.Drawing.Point(-1, 120);
            this.RDXRegisterLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.RDXRegisterLabel.Name = "RDXRegisterLabel";
            this.RDXRegisterLabel.Size = new System.Drawing.Size(41, 17);
            this.RDXRegisterLabel.TabIndex = 7;
            this.RDXRegisterLabel.Text = "RDX:";
            // 
            // RCXRegisterValue
            // 
            this.RCXRegisterValue.BackColor = System.Drawing.SystemColors.Control;
            this.RCXRegisterValue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RCXRegisterValue.Location = new System.Drawing.Point(41, 143);
            this.RCXRegisterValue.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RCXRegisterValue.Name = "RCXRegisterValue";
            this.RCXRegisterValue.ReadOnly = true;
            this.RCXRegisterValue.Size = new System.Drawing.Size(153, 15);
            this.RCXRegisterValue.TabIndex = 10;
            this.RCXRegisterValue.Text = "0x0000000000000000";
            this.RCXRegisterValue.DoubleClick += new System.EventHandler(this.Register_DoubleClick);
            this.RCXRegisterValue.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Register_KeyDown);
            this.RCXRegisterValue.Leave += new System.EventHandler(this.Register_Leave);
            // 
            // RCXRegisterLabel
            // 
            this.RCXRegisterLabel.AutoSize = true;
            this.RCXRegisterLabel.Location = new System.Drawing.Point(-1, 143);
            this.RCXRegisterLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.RCXRegisterLabel.Name = "RCXRegisterLabel";
            this.RCXRegisterLabel.Size = new System.Drawing.Size(40, 17);
            this.RCXRegisterLabel.TabIndex = 9;
            this.RCXRegisterLabel.Text = "RCX:";
            // 
            // R8RegisterValue
            // 
            this.R8RegisterValue.BackColor = System.Drawing.SystemColors.Control;
            this.R8RegisterValue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.R8RegisterValue.Location = new System.Drawing.Point(41, 166);
            this.R8RegisterValue.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.R8RegisterValue.Name = "R8RegisterValue";
            this.R8RegisterValue.ReadOnly = true;
            this.R8RegisterValue.Size = new System.Drawing.Size(153, 15);
            this.R8RegisterValue.TabIndex = 12;
            this.R8RegisterValue.Text = "0x0000000000000000";
            this.R8RegisterValue.DoubleClick += new System.EventHandler(this.Register_DoubleClick);
            this.R8RegisterValue.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Register_KeyDown);
            this.R8RegisterValue.Leave += new System.EventHandler(this.Register_Leave);
            // 
            // R8RegisterLabel
            // 
            this.R8RegisterLabel.AutoSize = true;
            this.R8RegisterLabel.Location = new System.Drawing.Point(-1, 166);
            this.R8RegisterLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.R8RegisterLabel.Name = "R8RegisterLabel";
            this.R8RegisterLabel.Size = new System.Drawing.Size(30, 17);
            this.R8RegisterLabel.TabIndex = 11;
            this.R8RegisterLabel.Text = "R8:";
            // 
            // R9RegisterValue
            // 
            this.R9RegisterValue.BackColor = System.Drawing.SystemColors.Control;
            this.R9RegisterValue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.R9RegisterValue.Location = new System.Drawing.Point(41, 189);
            this.R9RegisterValue.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.R9RegisterValue.Name = "R9RegisterValue";
            this.R9RegisterValue.ReadOnly = true;
            this.R9RegisterValue.Size = new System.Drawing.Size(153, 15);
            this.R9RegisterValue.TabIndex = 14;
            this.R9RegisterValue.Text = "0x0000000000000000";
            this.R9RegisterValue.DoubleClick += new System.EventHandler(this.Register_DoubleClick);
            this.R9RegisterValue.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Register_KeyDown);
            this.R9RegisterValue.Leave += new System.EventHandler(this.Register_Leave);
            // 
            // R9RegisterLabel
            // 
            this.R9RegisterLabel.AutoSize = true;
            this.R9RegisterLabel.Location = new System.Drawing.Point(-1, 189);
            this.R9RegisterLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.R9RegisterLabel.Name = "R9RegisterLabel";
            this.R9RegisterLabel.Size = new System.Drawing.Size(30, 17);
            this.R9RegisterLabel.TabIndex = 13;
            this.R9RegisterLabel.Text = "R9:";
            // 
            // R10RegisterValue
            // 
            this.R10RegisterValue.BackColor = System.Drawing.SystemColors.Control;
            this.R10RegisterValue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.R10RegisterValue.Location = new System.Drawing.Point(271, 31);
            this.R10RegisterValue.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.R10RegisterValue.Name = "R10RegisterValue";
            this.R10RegisterValue.ReadOnly = true;
            this.R10RegisterValue.Size = new System.Drawing.Size(153, 15);
            this.R10RegisterValue.TabIndex = 16;
            this.R10RegisterValue.Text = "0x0000000000000000";
            this.R10RegisterValue.DoubleClick += new System.EventHandler(this.Register_DoubleClick);
            this.R10RegisterValue.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Register_KeyDown);
            this.R10RegisterValue.Leave += new System.EventHandler(this.Register_Leave);
            // 
            // R10RegisterLabel
            // 
            this.R10RegisterLabel.AutoSize = true;
            this.R10RegisterLabel.Location = new System.Drawing.Point(228, 31);
            this.R10RegisterLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.R10RegisterLabel.Name = "R10RegisterLabel";
            this.R10RegisterLabel.Size = new System.Drawing.Size(38, 17);
            this.R10RegisterLabel.TabIndex = 15;
            this.R10RegisterLabel.Text = "R10:";
            // 
            // R11RegisterValue
            // 
            this.R11RegisterValue.BackColor = System.Drawing.SystemColors.Control;
            this.R11RegisterValue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.R11RegisterValue.Location = new System.Drawing.Point(271, 54);
            this.R11RegisterValue.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.R11RegisterValue.Name = "R11RegisterValue";
            this.R11RegisterValue.ReadOnly = true;
            this.R11RegisterValue.Size = new System.Drawing.Size(153, 15);
            this.R11RegisterValue.TabIndex = 18;
            this.R11RegisterValue.Text = "0x0000000000000000";
            this.R11RegisterValue.DoubleClick += new System.EventHandler(this.Register_DoubleClick);
            this.R11RegisterValue.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Register_KeyDown);
            this.R11RegisterValue.Leave += new System.EventHandler(this.Register_Leave);
            // 
            // R11RegisterLabel
            // 
            this.R11RegisterLabel.AutoSize = true;
            this.R11RegisterLabel.Location = new System.Drawing.Point(228, 54);
            this.R11RegisterLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.R11RegisterLabel.Name = "R11RegisterLabel";
            this.R11RegisterLabel.Size = new System.Drawing.Size(38, 17);
            this.R11RegisterLabel.TabIndex = 17;
            this.R11RegisterLabel.Text = "R11:";
            // 
            // R12RegisterValue
            // 
            this.R12RegisterValue.BackColor = System.Drawing.SystemColors.Control;
            this.R12RegisterValue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.R12RegisterValue.Location = new System.Drawing.Point(271, 78);
            this.R12RegisterValue.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.R12RegisterValue.Name = "R12RegisterValue";
            this.R12RegisterValue.ReadOnly = true;
            this.R12RegisterValue.Size = new System.Drawing.Size(153, 15);
            this.R12RegisterValue.TabIndex = 20;
            this.R12RegisterValue.Text = "0x0000000000000000";
            this.R12RegisterValue.DoubleClick += new System.EventHandler(this.Register_DoubleClick);
            this.R12RegisterValue.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Register_KeyDown);
            this.R12RegisterValue.Leave += new System.EventHandler(this.Register_Leave);
            // 
            // R12RegisterLabel
            // 
            this.R12RegisterLabel.AutoSize = true;
            this.R12RegisterLabel.Location = new System.Drawing.Point(228, 78);
            this.R12RegisterLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.R12RegisterLabel.Name = "R12RegisterLabel";
            this.R12RegisterLabel.Size = new System.Drawing.Size(38, 17);
            this.R12RegisterLabel.TabIndex = 19;
            this.R12RegisterLabel.Text = "R12:";
            // 
            // R13RegisterValue
            // 
            this.R13RegisterValue.BackColor = System.Drawing.SystemColors.Control;
            this.R13RegisterValue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.R13RegisterValue.Location = new System.Drawing.Point(271, 101);
            this.R13RegisterValue.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.R13RegisterValue.Name = "R13RegisterValue";
            this.R13RegisterValue.ReadOnly = true;
            this.R13RegisterValue.Size = new System.Drawing.Size(153, 15);
            this.R13RegisterValue.TabIndex = 22;
            this.R13RegisterValue.Text = "0x0000000000000000";
            this.R13RegisterValue.DoubleClick += new System.EventHandler(this.Register_DoubleClick);
            this.R13RegisterValue.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Register_KeyDown);
            this.R13RegisterValue.Leave += new System.EventHandler(this.Register_Leave);
            // 
            // R13RegisterLabel
            // 
            this.R13RegisterLabel.AutoSize = true;
            this.R13RegisterLabel.Location = new System.Drawing.Point(228, 101);
            this.R13RegisterLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.R13RegisterLabel.Name = "R13RegisterLabel";
            this.R13RegisterLabel.Size = new System.Drawing.Size(38, 17);
            this.R13RegisterLabel.TabIndex = 21;
            this.R13RegisterLabel.Text = "R13:";
            // 
            // R14RegisterValue
            // 
            this.R14RegisterValue.BackColor = System.Drawing.SystemColors.Control;
            this.R14RegisterValue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.R14RegisterValue.Location = new System.Drawing.Point(271, 124);
            this.R14RegisterValue.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.R14RegisterValue.Name = "R14RegisterValue";
            this.R14RegisterValue.ReadOnly = true;
            this.R14RegisterValue.Size = new System.Drawing.Size(153, 15);
            this.R14RegisterValue.TabIndex = 24;
            this.R14RegisterValue.Text = "0x0000000000000000";
            this.R14RegisterValue.DoubleClick += new System.EventHandler(this.Register_DoubleClick);
            this.R14RegisterValue.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Register_KeyDown);
            this.R14RegisterValue.Leave += new System.EventHandler(this.Register_Leave);
            // 
            // R14RegisterLabel
            // 
            this.R14RegisterLabel.AutoSize = true;
            this.R14RegisterLabel.Location = new System.Drawing.Point(228, 124);
            this.R14RegisterLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.R14RegisterLabel.Name = "R14RegisterLabel";
            this.R14RegisterLabel.Size = new System.Drawing.Size(38, 17);
            this.R14RegisterLabel.TabIndex = 23;
            this.R14RegisterLabel.Text = "R14:";
            // 
            // R15RegisterValue
            // 
            this.R15RegisterValue.BackColor = System.Drawing.SystemColors.Control;
            this.R15RegisterValue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.R15RegisterValue.Location = new System.Drawing.Point(271, 148);
            this.R15RegisterValue.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.R15RegisterValue.Name = "R15RegisterValue";
            this.R15RegisterValue.ReadOnly = true;
            this.R15RegisterValue.Size = new System.Drawing.Size(153, 15);
            this.R15RegisterValue.TabIndex = 26;
            this.R15RegisterValue.Text = "0x0000000000000000";
            this.R15RegisterValue.DoubleClick += new System.EventHandler(this.Register_DoubleClick);
            this.R15RegisterValue.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Register_KeyDown);
            this.R15RegisterValue.Leave += new System.EventHandler(this.Register_Leave);
            // 
            // R15RegisterLabel
            // 
            this.R15RegisterLabel.AutoSize = true;
            this.R15RegisterLabel.Location = new System.Drawing.Point(228, 148);
            this.R15RegisterLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.R15RegisterLabel.Name = "R15RegisterLabel";
            this.R15RegisterLabel.Size = new System.Drawing.Size(38, 17);
            this.R15RegisterLabel.TabIndex = 25;
            this.R15RegisterLabel.Text = "R15:";
            // 
            // RSPRegisterValue
            // 
            this.RSPRegisterValue.BackColor = System.Drawing.SystemColors.Control;
            this.RSPRegisterValue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RSPRegisterValue.Location = new System.Drawing.Point(503, 31);
            this.RSPRegisterValue.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RSPRegisterValue.Name = "RSPRegisterValue";
            this.RSPRegisterValue.ReadOnly = true;
            this.RSPRegisterValue.Size = new System.Drawing.Size(153, 15);
            this.RSPRegisterValue.TabIndex = 28;
            this.RSPRegisterValue.Text = "0x0000000000000000";
            this.RSPRegisterValue.DoubleClick += new System.EventHandler(this.Register_DoubleClick);
            this.RSPRegisterValue.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Register_KeyDown);
            this.RSPRegisterValue.Leave += new System.EventHandler(this.Register_Leave);
            // 
            // RSPRegisterLabel
            // 
            this.RSPRegisterLabel.AutoSize = true;
            this.RSPRegisterLabel.Location = new System.Drawing.Point(460, 31);
            this.RSPRegisterLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.RSPRegisterLabel.Name = "RSPRegisterLabel";
            this.RSPRegisterLabel.Size = new System.Drawing.Size(40, 17);
            this.RSPRegisterLabel.TabIndex = 27;
            this.RSPRegisterLabel.Text = "RSP:";
            // 
            // RBPRegisterValue
            // 
            this.RBPRegisterValue.BackColor = System.Drawing.SystemColors.Control;
            this.RBPRegisterValue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RBPRegisterValue.Location = new System.Drawing.Point(503, 54);
            this.RBPRegisterValue.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RBPRegisterValue.Name = "RBPRegisterValue";
            this.RBPRegisterValue.ReadOnly = true;
            this.RBPRegisterValue.Size = new System.Drawing.Size(153, 15);
            this.RBPRegisterValue.TabIndex = 30;
            this.RBPRegisterValue.Text = "0x0000000000000000";
            this.RBPRegisterValue.DoubleClick += new System.EventHandler(this.Register_DoubleClick);
            this.RBPRegisterValue.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Register_KeyDown);
            this.RBPRegisterValue.Leave += new System.EventHandler(this.Register_Leave);
            // 
            // RBPRegisterLabel
            // 
            this.RBPRegisterLabel.AutoSize = true;
            this.RBPRegisterLabel.Location = new System.Drawing.Point(460, 54);
            this.RBPRegisterLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.RBPRegisterLabel.Name = "RBPRegisterLabel";
            this.RBPRegisterLabel.Size = new System.Drawing.Size(40, 17);
            this.RBPRegisterLabel.TabIndex = 29;
            this.RBPRegisterLabel.Text = "RBP:";
            // 
            // RIPRegisterValue
            // 
            this.RIPRegisterValue.BackColor = System.Drawing.SystemColors.Control;
            this.RIPRegisterValue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RIPRegisterValue.Location = new System.Drawing.Point(503, 78);
            this.RIPRegisterValue.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RIPRegisterValue.Name = "RIPRegisterValue";
            this.RIPRegisterValue.ReadOnly = true;
            this.RIPRegisterValue.Size = new System.Drawing.Size(153, 15);
            this.RIPRegisterValue.TabIndex = 32;
            this.RIPRegisterValue.Text = "0x0000000000000000";
            this.RIPRegisterValue.DoubleClick += new System.EventHandler(this.Register_DoubleClick);
            this.RIPRegisterValue.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Register_KeyDown);
            this.RIPRegisterValue.Leave += new System.EventHandler(this.Register_Leave);
            // 
            // RIPRegisterLabel
            // 
            this.RIPRegisterLabel.AutoSize = true;
            this.RIPRegisterLabel.Location = new System.Drawing.Point(460, 78);
            this.RIPRegisterLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.RIPRegisterLabel.Name = "RIPRegisterLabel";
            this.RIPRegisterLabel.Size = new System.Drawing.Size(34, 17);
            this.RIPRegisterLabel.TabIndex = 31;
            this.RIPRegisterLabel.Text = "RIP:";
            // 
            // TrapRegisterValue
            // 
            this.TrapRegisterValue.BackColor = System.Drawing.SystemColors.Control;
            this.TrapRegisterValue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TrapRegisterValue.Location = new System.Drawing.Point(503, 101);
            this.TrapRegisterValue.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TrapRegisterValue.Name = "TrapRegisterValue";
            this.TrapRegisterValue.ReadOnly = true;
            this.TrapRegisterValue.Size = new System.Drawing.Size(153, 15);
            this.TrapRegisterValue.TabIndex = 34;
            this.TrapRegisterValue.Text = "0x0000000000000000";
            this.TrapRegisterValue.DoubleClick += new System.EventHandler(this.Register_DoubleClick);
            this.TrapRegisterValue.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Register_KeyDown);
            this.TrapRegisterValue.Leave += new System.EventHandler(this.Register_Leave);
            // 
            // TrapRegisterLabel
            // 
            this.TrapRegisterLabel.AutoSize = true;
            this.TrapRegisterLabel.Location = new System.Drawing.Point(460, 101);
            this.TrapRegisterLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TrapRegisterLabel.Name = "TrapRegisterLabel";
            this.TrapRegisterLabel.Size = new System.Drawing.Size(42, 17);
            this.TrapRegisterLabel.TabIndex = 33;
            this.TrapRegisterLabel.Text = "Trap:";
            // 
            // ErrRegisterValue
            // 
            this.ErrRegisterValue.BackColor = System.Drawing.SystemColors.Control;
            this.ErrRegisterValue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ErrRegisterValue.Location = new System.Drawing.Point(503, 124);
            this.ErrRegisterValue.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ErrRegisterValue.Name = "ErrRegisterValue";
            this.ErrRegisterValue.ReadOnly = true;
            this.ErrRegisterValue.Size = new System.Drawing.Size(153, 15);
            this.ErrRegisterValue.TabIndex = 36;
            this.ErrRegisterValue.Text = "0x0000000000000000";
            this.ErrRegisterValue.DoubleClick += new System.EventHandler(this.Register_DoubleClick);
            this.ErrRegisterValue.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Register_KeyDown);
            this.ErrRegisterValue.Leave += new System.EventHandler(this.Register_Leave);
            // 
            // ErrRegisterLabel
            // 
            this.ErrRegisterLabel.AutoSize = true;
            this.ErrRegisterLabel.Location = new System.Drawing.Point(460, 124);
            this.ErrRegisterLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ErrRegisterLabel.Name = "ErrRegisterLabel";
            this.ErrRegisterLabel.Size = new System.Drawing.Size(31, 17);
            this.ErrRegisterLabel.TabIndex = 35;
            this.ErrRegisterLabel.Text = "Err:";
            // 
            // rFlagRegisterValue
            // 
            this.rFlagRegisterValue.BackColor = System.Drawing.SystemColors.Control;
            this.rFlagRegisterValue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rFlagRegisterValue.Location = new System.Drawing.Point(503, 148);
            this.rFlagRegisterValue.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rFlagRegisterValue.Name = "rFlagRegisterValue";
            this.rFlagRegisterValue.ReadOnly = true;
            this.rFlagRegisterValue.Size = new System.Drawing.Size(153, 15);
            this.rFlagRegisterValue.TabIndex = 38;
            this.rFlagRegisterValue.Text = "0x0000000000000000";
            this.rFlagRegisterValue.DoubleClick += new System.EventHandler(this.Register_DoubleClick);
            this.rFlagRegisterValue.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Register_KeyDown);
            this.rFlagRegisterValue.Leave += new System.EventHandler(this.Register_Leave);
            // 
            // rFlagRegisterLabel
            // 
            this.rFlagRegisterLabel.AutoSize = true;
            this.rFlagRegisterLabel.Location = new System.Drawing.Point(460, 148);
            this.rFlagRegisterLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.rFlagRegisterLabel.Name = "rFlagRegisterLabel";
            this.rFlagRegisterLabel.Size = new System.Drawing.Size(44, 17);
            this.rFlagRegisterLabel.TabIndex = 37;
            this.rFlagRegisterLabel.Text = "rFlag:";
            // 
            // RBXRegisterValue
            // 
            this.RBXRegisterValue.BackColor = System.Drawing.SystemColors.Control;
            this.RBXRegisterValue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RBXRegisterValue.Location = new System.Drawing.Point(41, 53);
            this.RBXRegisterValue.Margin = new System.Windows.Forms.Padding(4);
            this.RBXRegisterValue.Name = "RBXRegisterValue";
            this.RBXRegisterValue.ReadOnly = true;
            this.RBXRegisterValue.Size = new System.Drawing.Size(153, 15);
            this.RBXRegisterValue.TabIndex = 40;
            this.RBXRegisterValue.Text = "0x0000000000000000";
            this.RBXRegisterValue.DoubleClick += new System.EventHandler(this.Register_DoubleClick);
            this.RBXRegisterValue.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Register_KeyDown);
            this.RBXRegisterValue.Leave += new System.EventHandler(this.Register_Leave);
            // 
            // RBXRegisterLabel
            // 
            this.RBXRegisterLabel.AutoSize = true;
            this.RBXRegisterLabel.Location = new System.Drawing.Point(-1, 53);
            this.RBXRegisterLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.RBXRegisterLabel.Name = "RBXRegisterLabel";
            this.RBXRegisterLabel.Size = new System.Drawing.Size(40, 17);
            this.RBXRegisterLabel.TabIndex = 39;
            this.RBXRegisterLabel.Text = "RBX:";
            // 
            // RegistersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 235);
            this.Controls.Add(this.RBXRegisterValue);
            this.Controls.Add(this.RBXRegisterLabel);
            this.Controls.Add(this.rFlagRegisterValue);
            this.Controls.Add(this.rFlagRegisterLabel);
            this.Controls.Add(this.ErrRegisterValue);
            this.Controls.Add(this.ErrRegisterLabel);
            this.Controls.Add(this.TrapRegisterValue);
            this.Controls.Add(this.TrapRegisterLabel);
            this.Controls.Add(this.RIPRegisterValue);
            this.Controls.Add(this.RIPRegisterLabel);
            this.Controls.Add(this.RBPRegisterValue);
            this.Controls.Add(this.RBPRegisterLabel);
            this.Controls.Add(this.RSPRegisterValue);
            this.Controls.Add(this.RSPRegisterLabel);
            this.Controls.Add(this.R15RegisterValue);
            this.Controls.Add(this.R15RegisterLabel);
            this.Controls.Add(this.R14RegisterValue);
            this.Controls.Add(this.R14RegisterLabel);
            this.Controls.Add(this.R13RegisterValue);
            this.Controls.Add(this.R13RegisterLabel);
            this.Controls.Add(this.R12RegisterValue);
            this.Controls.Add(this.R12RegisterLabel);
            this.Controls.Add(this.R11RegisterValue);
            this.Controls.Add(this.R11RegisterLabel);
            this.Controls.Add(this.R10RegisterValue);
            this.Controls.Add(this.R10RegisterLabel);
            this.Controls.Add(this.R9RegisterValue);
            this.Controls.Add(this.R9RegisterLabel);
            this.Controls.Add(this.R8RegisterValue);
            this.Controls.Add(this.R8RegisterLabel);
            this.Controls.Add(this.RCXRegisterValue);
            this.Controls.Add(this.RCXRegisterLabel);
            this.Controls.Add(this.RDXRegisterValue);
            this.Controls.Add(this.RDXRegisterLabel);
            this.Controls.Add(this.RSIRegisterValue);
            this.Controls.Add(this.RSIRegisterLabel);
            this.Controls.Add(this.RDIRegisterValue);
            this.Controls.Add(this.RDIRegisterLabel);
            this.Controls.Add(this.RAXRegisterValue);
            this.Controls.Add(this.RAXRegisterLabel);
            this.Controls.Add(this.RegistersToolStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "RegistersForm";
            this.Text = "Current Process Registers";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.RegistersForm_FormClosed);
            this.RegistersToolStrip.ResumeLayout(false);
            this.RegistersToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip RegistersToolStrip;
        private System.Windows.Forms.ToolStripButton RefreshRegistersButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton SetRegistersButton;
        private System.Windows.Forms.Label RAXRegisterLabel;
        private System.Windows.Forms.TextBox RAXRegisterValue;
        private System.Windows.Forms.TextBox RDIRegisterValue;
        private System.Windows.Forms.Label RDIRegisterLabel;
        private System.Windows.Forms.TextBox RSIRegisterValue;
        private System.Windows.Forms.Label RSIRegisterLabel;
        private System.Windows.Forms.TextBox RDXRegisterValue;
        private System.Windows.Forms.Label RDXRegisterLabel;
        private System.Windows.Forms.TextBox RCXRegisterValue;
        private System.Windows.Forms.Label RCXRegisterLabel;
        private System.Windows.Forms.TextBox R8RegisterValue;
        private System.Windows.Forms.Label R8RegisterLabel;
        private System.Windows.Forms.TextBox R9RegisterValue;
        private System.Windows.Forms.Label R9RegisterLabel;
        private System.Windows.Forms.TextBox R10RegisterValue;
        private System.Windows.Forms.Label R10RegisterLabel;
        private System.Windows.Forms.TextBox R11RegisterValue;
        private System.Windows.Forms.Label R11RegisterLabel;
        private System.Windows.Forms.TextBox R12RegisterValue;
        private System.Windows.Forms.Label R12RegisterLabel;
        private System.Windows.Forms.TextBox R13RegisterValue;
        private System.Windows.Forms.Label R13RegisterLabel;
        private System.Windows.Forms.TextBox R14RegisterValue;
        private System.Windows.Forms.Label R14RegisterLabel;
        private System.Windows.Forms.TextBox R15RegisterValue;
        private System.Windows.Forms.Label R15RegisterLabel;
        private System.Windows.Forms.TextBox RSPRegisterValue;
        private System.Windows.Forms.Label RSPRegisterLabel;
        private System.Windows.Forms.TextBox RBPRegisterValue;
        private System.Windows.Forms.Label RBPRegisterLabel;
        private System.Windows.Forms.TextBox RIPRegisterValue;
        private System.Windows.Forms.Label RIPRegisterLabel;
        private System.Windows.Forms.TextBox TrapRegisterValue;
        private System.Windows.Forms.Label TrapRegisterLabel;
        private System.Windows.Forms.TextBox ErrRegisterValue;
        private System.Windows.Forms.Label ErrRegisterLabel;
        private System.Windows.Forms.TextBox rFlagRegisterValue;
        private System.Windows.Forms.Label rFlagRegisterLabel;
        private System.Windows.Forms.TextBox RBXRegisterValue;
        private System.Windows.Forms.Label RBXRegisterLabel;
    }
}
