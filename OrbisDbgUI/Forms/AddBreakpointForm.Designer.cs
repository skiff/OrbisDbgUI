namespace OrbisDbgUI {
    partial class AddBreakpointForm {
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
            this.AddNewBreakpointButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.BreakpointAddressTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BreakpointEnabledCheckbox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // AddNewBreakpointButton
            // 
            this.AddNewBreakpointButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.AddNewBreakpointButton.Location = new System.Drawing.Point(12, 60);
            this.AddNewBreakpointButton.Name = "AddNewBreakpointButton";
            this.AddNewBreakpointButton.Size = new System.Drawing.Size(117, 23);
            this.AddNewBreakpointButton.TabIndex = 0;
            this.AddNewBreakpointButton.Text = "Add New Breakpoint";
            this.AddNewBreakpointButton.UseVisualStyleBackColor = true;
            this.AddNewBreakpointButton.Click += new System.EventHandler(this.AddNewBreakpoint_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(135, 60);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(63, 23);
            this.CancelButton.TabIndex = 1;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Address:";
            // 
            // BreakpointAddressTextBox
            // 
            this.BreakpointAddressTextBox.Location = new System.Drawing.Point(68, 13);
            this.BreakpointAddressTextBox.Name = "BreakpointAddressTextBox";
            this.BreakpointAddressTextBox.Size = new System.Drawing.Size(130, 20);
            this.BreakpointAddressTextBox.TabIndex = 3;
            this.BreakpointAddressTextBox.Text = "0x0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Enabled:";
            // 
            // BreakpointEnabledCheckbox
            // 
            this.BreakpointEnabledCheckbox.AutoSize = true;
            this.BreakpointEnabledCheckbox.Location = new System.Drawing.Point(69, 40);
            this.BreakpointEnabledCheckbox.Name = "BreakpointEnabledCheckbox";
            this.BreakpointEnabledCheckbox.Size = new System.Drawing.Size(15, 14);
            this.BreakpointEnabledCheckbox.TabIndex = 5;
            this.BreakpointEnabledCheckbox.UseVisualStyleBackColor = true;
            // 
            // AddBreakpointForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(210, 95);
            this.Controls.Add(this.BreakpointEnabledCheckbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BreakpointAddressTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.AddNewBreakpointButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AddBreakpointForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Software Breakpoint";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddNewBreakpointButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox BreakpointAddressTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox BreakpointEnabledCheckbox;
    }
}