namespace OrbisDbgUI {
    partial class MemoryForm {
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
            this.components = new System.ComponentModel.Container();
            this.MemoryViewHexBox = new Be.Windows.Forms.HexBox();
            this.MemoryViewContextStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.followPointerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backtracePointerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.OneByteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TwoBytesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FourBytesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EightBytesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FullBytesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.copySelectedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MemoryToolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.AddressToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.LengthToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.PeekToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.PokeToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.SaveToolstripButton = new System.Windows.Forms.ToolStripButton();
            this.MemoryViewContextStrip.SuspendLayout();
            this.MemoryToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // MemoryViewHexBox
            // 
            this.MemoryViewHexBox.ColumnInfoVisible = true;
            this.MemoryViewHexBox.ContextMenuStrip = this.MemoryViewContextStrip;
            this.MemoryViewHexBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MemoryViewHexBox.LineInfoVisible = true;
            this.MemoryViewHexBox.Location = new System.Drawing.Point(0, 28);
            this.MemoryViewHexBox.Name = "MemoryViewHexBox";
            this.MemoryViewHexBox.ShadowSelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(60)))), ((int)(((byte)(188)))), ((int)(((byte)(255)))));
            this.MemoryViewHexBox.Size = new System.Drawing.Size(639, 501);
            this.MemoryViewHexBox.StringViewVisible = true;
            this.MemoryViewHexBox.TabIndex = 0;
            this.MemoryViewHexBox.UseFixedBytesPerLine = true;
            this.MemoryViewHexBox.VScrollBarVisible = true;
            this.MemoryViewHexBox.Copied += new System.EventHandler(this.MemoryViewHexBox_Copied);
            this.MemoryViewHexBox.Click += new System.EventHandler(this.MemoryViewHexBox_Click);
            // 
            // MemoryViewContextStrip
            // 
            this.MemoryViewContextStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.followPointerToolStripMenuItem,
            this.backtracePointerToolStripMenuItem,
            this.toolStripSeparator2,
            this.OneByteToolStripMenuItem,
            this.TwoBytesToolStripMenuItem,
            this.FourBytesToolStripMenuItem,
            this.EightBytesToolStripMenuItem,
            this.FullBytesToolStripMenuItem,
            this.toolStripSeparator3,
            this.copySelectedToolStripMenuItem});
            this.MemoryViewContextStrip.Name = "MemoryViewContextStrip";
            this.MemoryViewContextStrip.Size = new System.Drawing.Size(167, 192);
            // 
            // followPointerToolStripMenuItem
            // 
            this.followPointerToolStripMenuItem.Name = "followPointerToolStripMenuItem";
            this.followPointerToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.followPointerToolStripMenuItem.Text = "Follow Pointer";
            this.followPointerToolStripMenuItem.Click += new System.EventHandler(this.followPointerToolStripMenuItem_Click);
            // 
            // backtracePointerToolStripMenuItem
            // 
            this.backtracePointerToolStripMenuItem.Name = "backtracePointerToolStripMenuItem";
            this.backtracePointerToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.backtracePointerToolStripMenuItem.Text = "Backtrace Pointer";
            this.backtracePointerToolStripMenuItem.Click += new System.EventHandler(this.backtracePointerToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(163, 6);
            // 
            // OneByteToolStripMenuItem
            // 
            this.OneByteToolStripMenuItem.Name = "OneByteToolStripMenuItem";
            this.OneByteToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.OneByteToolStripMenuItem.Text = "1 Byte";
            this.OneByteToolStripMenuItem.Click += new System.EventHandler(this.ChangeByteLayout_Click);
            // 
            // TwoBytesToolStripMenuItem
            // 
            this.TwoBytesToolStripMenuItem.Name = "TwoBytesToolStripMenuItem";
            this.TwoBytesToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.TwoBytesToolStripMenuItem.Text = "2 Bytes";
            this.TwoBytesToolStripMenuItem.Click += new System.EventHandler(this.ChangeByteLayout_Click);
            // 
            // FourBytesToolStripMenuItem
            // 
            this.FourBytesToolStripMenuItem.Name = "FourBytesToolStripMenuItem";
            this.FourBytesToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.FourBytesToolStripMenuItem.Text = "4 Bytes";
            this.FourBytesToolStripMenuItem.Click += new System.EventHandler(this.ChangeByteLayout_Click);
            // 
            // EightBytesToolStripMenuItem
            // 
            this.EightBytesToolStripMenuItem.Name = "EightBytesToolStripMenuItem";
            this.EightBytesToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.EightBytesToolStripMenuItem.Text = "8 Bytes";
            this.EightBytesToolStripMenuItem.Click += new System.EventHandler(this.ChangeByteLayout_Click);
            // 
            // FullBytesToolStripMenuItem
            // 
            this.FullBytesToolStripMenuItem.Name = "FullBytesToolStripMenuItem";
            this.FullBytesToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.FullBytesToolStripMenuItem.Text = "16 Bytes";
            this.FullBytesToolStripMenuItem.Click += new System.EventHandler(this.ChangeByteLayout_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(163, 6);
            // 
            // copySelectedToolStripMenuItem
            // 
            this.copySelectedToolStripMenuItem.Name = "copySelectedToolStripMenuItem";
            this.copySelectedToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.copySelectedToolStripMenuItem.Text = "Copy Selected";
            this.copySelectedToolStripMenuItem.Click += new System.EventHandler(this.copySelectedToolStripMenuItem_Click);
            // 
            // MemoryToolStrip
            // 
            this.MemoryToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.AddressToolStripTextBox,
            this.toolStripLabel2,
            this.LengthToolStripTextBox,
            this.toolStripSeparator1,
            this.PeekToolStripButton,
            this.PokeToolStripButton,
            this.SaveToolstripButton});
            this.MemoryToolStrip.Location = new System.Drawing.Point(0, 0);
            this.MemoryToolStrip.Name = "MemoryToolStrip";
            this.MemoryToolStrip.Size = new System.Drawing.Size(639, 25);
            this.MemoryToolStrip.TabIndex = 1;
            this.MemoryToolStrip.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(49, 22);
            this.toolStripLabel1.Text = "Address";
            // 
            // AddressToolStripTextBox
            // 
            this.AddressToolStripTextBox.Name = "AddressToolStripTextBox";
            this.AddressToolStripTextBox.Size = new System.Drawing.Size(120, 25);
            this.AddressToolStripTextBox.Text = "0x0000000000400000";
            this.AddressToolStripTextBox.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(44, 22);
            this.toolStripLabel2.Text = "Length";
            // 
            // LengthToolStripTextBox
            // 
            this.LengthToolStripTextBox.Name = "LengthToolStripTextBox";
            this.LengthToolStripTextBox.Size = new System.Drawing.Size(100, 25);
            this.LengthToolStripTextBox.Text = "0x1000";
            this.LengthToolStripTextBox.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // PeekToolStripButton
            // 
            this.PeekToolStripButton.Image = global::OrbisDbgUI.Properties.Resources.peek;
            this.PeekToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.PeekToolStripButton.Name = "PeekToolStripButton";
            this.PeekToolStripButton.Size = new System.Drawing.Size(52, 22);
            this.PeekToolStripButton.Text = "Peek";
            this.PeekToolStripButton.Click += new System.EventHandler(this.PeekToolStripButton_Click);
            // 
            // PokeToolStripButton
            // 
            this.PokeToolStripButton.Image = global::OrbisDbgUI.Properties.Resources.poke;
            this.PokeToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.PokeToolStripButton.Name = "PokeToolStripButton";
            this.PokeToolStripButton.Size = new System.Drawing.Size(53, 22);
            this.PokeToolStripButton.Text = "Poke";
            this.PokeToolStripButton.Click += new System.EventHandler(this.PokeToolStripButton_Click);
            // 
            // SaveToolstripButton
            // 
            this.SaveToolstripButton.Image = global::OrbisDbgUI.Properties.Resources.save;
            this.SaveToolstripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SaveToolstripButton.Name = "SaveToolstripButton";
            this.SaveToolstripButton.Size = new System.Drawing.Size(51, 22);
            this.SaveToolstripButton.Text = "Save";
            this.SaveToolstripButton.Click += new System.EventHandler(this.SaveToolstripButton_Click);
            // 
            // MemoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 529);
            this.Controls.Add(this.MemoryToolStrip);
            this.Controls.Add(this.MemoryViewHexBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "MemoryForm";
            this.Text = "Memory Editor Window";
            this.Resize += new System.EventHandler(this.MemoryForm_Resize);
            this.MemoryViewContextStrip.ResumeLayout(false);
            this.MemoryToolStrip.ResumeLayout(false);
            this.MemoryToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Be.Windows.Forms.HexBox MemoryViewHexBox;
        private System.Windows.Forms.ToolStrip MemoryToolStrip;
        private System.Windows.Forms.ToolStripTextBox AddressToolStripTextBox;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox LengthToolStripTextBox;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton PeekToolStripButton;
        private System.Windows.Forms.ToolStripButton PokeToolStripButton;
        private System.Windows.Forms.ToolStripButton SaveToolstripButton;
        private System.Windows.Forms.ContextMenuStrip MemoryViewContextStrip;
        private System.Windows.Forms.ToolStripMenuItem followPointerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backtracePointerToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem OneByteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TwoBytesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem FourBytesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EightBytesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem FullBytesToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem copySelectedToolStripMenuItem;
    }
}