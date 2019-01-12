namespace OrbisDbgUI {
    partial class DisassemblyForm {
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
            this.DisassemblyRichTextBot = new System.Windows.Forms.RichTextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.DisassemblyAddress = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.UpdateDisassemblyToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.ShowBytesCheckBox = new System.Windows.Forms.CheckBox();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DisassemblyRichTextBot
            // 
            this.DisassemblyRichTextBot.BackColor = System.Drawing.SystemColors.Control;
            this.DisassemblyRichTextBot.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DisassemblyRichTextBot.Location = new System.Drawing.Point(0, 28);
            this.DisassemblyRichTextBot.Name = "DisassemblyRichTextBot";
            this.DisassemblyRichTextBot.Size = new System.Drawing.Size(581, 477);
            this.DisassemblyRichTextBot.TabIndex = 0;
            this.DisassemblyRichTextBot.Text = "";
            this.DisassemblyRichTextBot.WordWrap = false;
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.DisassemblyAddress,
            this.toolStripSeparator1,
            this.UpdateDisassemblyToolStripButton,
            this.toolStripSeparator2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(581, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(49, 22);
            this.toolStripLabel1.Text = "Address";
            // 
            // DisassemblyAddress
            // 
            this.DisassemblyAddress.Name = "DisassemblyAddress";
            this.DisassemblyAddress.Size = new System.Drawing.Size(100, 25);
            this.DisassemblyAddress.Text = "0x0";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // UpdateDisassemblyToolStripButton
            // 
            this.UpdateDisassemblyToolStripButton.Image = global::OrbisDbgUI.Properties.Resources.refresh;
            this.UpdateDisassemblyToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.UpdateDisassemblyToolStripButton.Name = "UpdateDisassemblyToolStripButton";
            this.UpdateDisassemblyToolStripButton.Size = new System.Drawing.Size(133, 22);
            this.UpdateDisassemblyToolStripButton.Text = "Update Disassembly";
            this.UpdateDisassemblyToolStripButton.Click += new System.EventHandler(this.UpdateDisassemblyToolStripButton_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // ShowBytesCheckBox
            // 
            this.ShowBytesCheckBox.AutoSize = true;
            this.ShowBytesCheckBox.BackColor = System.Drawing.SystemColors.Control;
            this.ShowBytesCheckBox.Checked = true;
            this.ShowBytesCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ShowBytesCheckBox.Location = new System.Drawing.Point(308, 5);
            this.ShowBytesCheckBox.Name = "ShowBytesCheckBox";
            this.ShowBytesCheckBox.Size = new System.Drawing.Size(82, 17);
            this.ShowBytesCheckBox.TabIndex = 2;
            this.ShowBytesCheckBox.Text = "Show Bytes";
            this.ShowBytesCheckBox.UseVisualStyleBackColor = false;
            this.ShowBytesCheckBox.CheckedChanged += new System.EventHandler(this.ShowBytesCheckBox_CheckedChanged);
            // 
            // DisassemblyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 507);
            this.Controls.Add(this.ShowBytesCheckBox);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.DisassemblyRichTextBot);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "DisassemblyForm";
            this.Text = "Disassembly Window";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DisassemblyForm_FormClosing);
            this.Resize += new System.EventHandler(this.DisassemblyForm_Resize);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox DisassemblyRichTextBot;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox DisassemblyAddress;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton UpdateDisassemblyToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.CheckBox ShowBytesCheckBox;
    }
}