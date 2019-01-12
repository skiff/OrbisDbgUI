using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace OrbisDbgUI {
    public partial class SelectAttachedTarget : Form {
        public string SelectedProcess { get; set; }

        public SelectAttachedTarget() {
            InitializeComponent();
        }

        public SelectAttachedTarget(List<Process> pList) {
            InitializeComponent();

            attachedProcessDataGridView.Rows.Clear();

            for(int i = 0; i < pList.Count; i++) {
                if (pList[i].attached != 0)
                    attachedProcessDataGridView.Rows.Add(pList[i].name, pList[i].pid);
            }
        }

        private void DoNotContinueButton_Click(object sender, EventArgs e) {
            this.DialogResult = DialogResult.None;
            this.Close();
        }

        private void attachedProcessDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e) {
            if(e.ColumnIndex == 2 && e.RowIndex >= 0) {
                this.SelectedProcess = attachedProcessDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
