namespace OrbisDbgUI {
    partial class ProcessesForm {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProcessesForm));
            this.ProcessesListDataGridView = new System.Windows.Forms.DataGridView();
            this.ProcessName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProcessID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProcessAttached = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ProcessAttach = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ProcessDetach = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ProcessesListDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ProcessesListDataGridView
            // 
            this.ProcessesListDataGridView.AllowUserToAddRows = false;
            this.ProcessesListDataGridView.AllowUserToResizeColumns = false;
            this.ProcessesListDataGridView.AllowUserToResizeRows = false;
            this.ProcessesListDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProcessesListDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProcessName,
            this.ProcessID,
            this.ProcessAttached,
            this.ProcessAttach,
            this.ProcessDetach});
            this.ProcessesListDataGridView.Location = new System.Drawing.Point(0, 0);
            this.ProcessesListDataGridView.Name = "ProcessesListDataGridView";
            this.ProcessesListDataGridView.RowHeadersVisible = false;
            this.ProcessesListDataGridView.Size = new System.Drawing.Size(380, 150);
            this.ProcessesListDataGridView.TabIndex = 0;
            this.ProcessesListDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProcessesListDataGridView_CellContentClick);
            // 
            // ProcessName
            // 
            this.ProcessName.Frozen = true;
            this.ProcessName.HeaderText = "Name";
            this.ProcessName.Name = "ProcessName";
            this.ProcessName.ReadOnly = true;
            this.ProcessName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ProcessName.Width = 135;
            // 
            // ProcessID
            // 
            this.ProcessID.HeaderText = "ID";
            this.ProcessID.Name = "ProcessID";
            this.ProcessID.ReadOnly = true;
            this.ProcessID.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ProcessID.Width = 50;
            // 
            // ProcessAttached
            // 
            this.ProcessAttached.HeaderText = "Attached?";
            this.ProcessAttached.Name = "ProcessAttached";
            this.ProcessAttached.ReadOnly = true;
            this.ProcessAttached.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ProcessAttached.Width = 75;
            // 
            // ProcessAttach
            // 
            this.ProcessAttach.HeaderText = "Attach";
            this.ProcessAttach.Name = "ProcessAttach";
            this.ProcessAttach.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ProcessAttach.Width = 50;
            // 
            // ProcessDetach
            // 
            this.ProcessDetach.HeaderText = "Detach";
            this.ProcessDetach.Name = "ProcessDetach";
            this.ProcessDetach.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ProcessDetach.Width = 50;
            // 
            // ProcessesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 150);
            this.Controls.Add(this.ProcessesListDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ProcessesForm";
            this.Text = "All Current Processes";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ProcessesForm_FormClosed);
            this.Resize += new System.EventHandler(this.ProcessesForm_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.ProcessesListDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView ProcessesListDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProcessName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProcessID;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ProcessAttached;
        private System.Windows.Forms.DataGridViewButtonColumn ProcessAttach;
        private System.Windows.Forms.DataGridViewButtonColumn ProcessDetach;
    }
}