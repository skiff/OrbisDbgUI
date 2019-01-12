namespace OrbisDbgUI {
    partial class BreakpointForm {
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.BreakpointsDataGridView = new System.Windows.Forms.DataGridView();
            this.BreakpointProcess = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BreakpointAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BreakpointEnabled = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.DeleteBreakpoint = new System.Windows.Forms.DataGridViewButtonColumn();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.AddBreakpointButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.RemoveBreakpointsButton = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.BreakpointsDataGridView)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BreakpointsDataGridView
            // 
            this.BreakpointsDataGridView.AllowUserToAddRows = false;
            this.BreakpointsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BreakpointsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BreakpointProcess,
            this.BreakpointAddress,
            this.BreakpointEnabled,
            this.DeleteBreakpoint});
            this.BreakpointsDataGridView.Location = new System.Drawing.Point(0, 28);
            this.BreakpointsDataGridView.Name = "BreakpointsDataGridView";
            this.BreakpointsDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.BreakpointsDataGridView.RowHeadersVisible = false;
            this.BreakpointsDataGridView.Size = new System.Drawing.Size(396, 98);
            this.BreakpointsDataGridView.TabIndex = 0;
            this.BreakpointsDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.BreakpointsDataGridView_CellContentClick);
            // 
            // BreakpointProcess
            // 
            this.BreakpointProcess.HeaderText = "Process";
            this.BreakpointProcess.Name = "BreakpointProcess";
            this.BreakpointProcess.ReadOnly = true;
            this.BreakpointProcess.Width = 125;
            // 
            // BreakpointAddress
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            this.BreakpointAddress.DefaultCellStyle = dataGridViewCellStyle1;
            this.BreakpointAddress.HeaderText = "Address";
            this.BreakpointAddress.Name = "BreakpointAddress";
            this.BreakpointAddress.ReadOnly = true;
            this.BreakpointAddress.Width = 125;
            // 
            // BreakpointEnabled
            // 
            this.BreakpointEnabled.HeaderText = "Enabled";
            this.BreakpointEnabled.Name = "BreakpointEnabled";
            this.BreakpointEnabled.Width = 65;
            // 
            // DeleteBreakpoint
            // 
            this.DeleteBreakpoint.HeaderText = "Delete";
            this.DeleteBreakpoint.Name = "DeleteBreakpoint";
            this.DeleteBreakpoint.Width = 65;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddBreakpointButton,
            this.toolStripSeparator1,
            this.RemoveBreakpointsButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(396, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // AddBreakpointButton
            // 
            this.AddBreakpointButton.Image = global::OrbisDbgUI.Properties.Resources.breakpoint;
            this.AddBreakpointButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AddBreakpointButton.Name = "AddBreakpointButton";
            this.AddBreakpointButton.Size = new System.Drawing.Size(109, 22);
            this.AddBreakpointButton.Text = "Add Breakpoint";
            this.AddBreakpointButton.Click += new System.EventHandler(this.AddBreakpointButton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // RemoveBreakpointsButton
            // 
            this.RemoveBreakpointsButton.Image = global::OrbisDbgUI.Properties.Resources.removeall;
            this.RemoveBreakpointsButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.RemoveBreakpointsButton.Name = "RemoveBreakpointsButton";
            this.RemoveBreakpointsButton.Size = new System.Drawing.Size(152, 22);
            this.RemoveBreakpointsButton.Text = "Remove All Breakpoints";
            this.RemoveBreakpointsButton.Click += new System.EventHandler(this.RemoveBreakpointsButton_Click);
            // 
            // BreakpointForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 126);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.BreakpointsDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "BreakpointForm";
            this.Text = "Software Breakpoints";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.BreakpointForm_FormClosed);
            this.Resize += new System.EventHandler(this.BreakpointForm_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.BreakpointsDataGridView)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView BreakpointsDataGridView;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton AddBreakpointButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton RemoveBreakpointsButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn BreakpointProcess;
        private System.Windows.Forms.DataGridViewTextBoxColumn BreakpointAddress;
        private System.Windows.Forms.DataGridViewCheckBoxColumn BreakpointEnabled;
        private System.Windows.Forms.DataGridViewButtonColumn DeleteBreakpoint;
    }
}