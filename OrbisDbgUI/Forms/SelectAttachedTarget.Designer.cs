namespace OrbisDbgUI {
    partial class SelectAttachedTarget {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelectAttachedTarget));
            this.label1 = new System.Windows.Forms.Label();
            this.attachedProcessDataGridView = new System.Windows.Forms.DataGridView();
            this.ProcessName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProcessID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SelectProcess = new System.Windows.Forms.DataGridViewButtonColumn();
            this.DoNotContinueButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.attachedProcessDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(329, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Would you like to continue debugging an already attached process?";
            // 
            // attachedProcessDataGridView
            // 
            this.attachedProcessDataGridView.AllowUserToAddRows = false;
            this.attachedProcessDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.attachedProcessDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProcessName,
            this.ProcessID,
            this.SelectProcess});
            this.attachedProcessDataGridView.Location = new System.Drawing.Point(12, 30);
            this.attachedProcessDataGridView.Name = "attachedProcessDataGridView";
            this.attachedProcessDataGridView.ReadOnly = true;
            this.attachedProcessDataGridView.RowHeadersVisible = false;
            this.attachedProcessDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.attachedProcessDataGridView.Size = new System.Drawing.Size(342, 179);
            this.attachedProcessDataGridView.TabIndex = 1;
            this.attachedProcessDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.attachedProcessDataGridView_CellContentClick);
            // 
            // ProcessName
            // 
            this.ProcessName.HeaderText = "Process Name";
            this.ProcessName.Name = "ProcessName";
            this.ProcessName.ReadOnly = true;
            this.ProcessName.Width = 150;
            // 
            // ProcessID
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            this.ProcessID.DefaultCellStyle = dataGridViewCellStyle1;
            this.ProcessID.HeaderText = "Process ID";
            this.ProcessID.Name = "ProcessID";
            this.ProcessID.ReadOnly = true;
            this.ProcessID.Width = 75;
            // 
            // SelectProcess
            // 
            this.SelectProcess.HeaderText = "Select Process";
            this.SelectProcess.Name = "SelectProcess";
            this.SelectProcess.ReadOnly = true;
            // 
            // DoNotContinueButton
            // 
            this.DoNotContinueButton.Location = new System.Drawing.Point(12, 216);
            this.DoNotContinueButton.Name = "DoNotContinueButton";
            this.DoNotContinueButton.Size = new System.Drawing.Size(342, 23);
            this.DoNotContinueButton.TabIndex = 2;
            this.DoNotContinueButton.Text = "Do Not Continue Debugging";
            this.DoNotContinueButton.UseVisualStyleBackColor = true;
            this.DoNotContinueButton.Click += new System.EventHandler(this.DoNotContinueButton_Click);
            // 
            // SelectAttachedTarget
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 245);
            this.Controls.Add(this.DoNotContinueButton);
            this.Controls.Add(this.attachedProcessDataGridView);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SelectAttachedTarget";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Continue Debugging Process";
            ((System.ComponentModel.ISupportInitialize)(this.attachedProcessDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView attachedProcessDataGridView;
        private System.Windows.Forms.Button DoNotContinueButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProcessName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProcessID;
        private System.Windows.Forms.DataGridViewButtonColumn SelectProcess;
    }
}