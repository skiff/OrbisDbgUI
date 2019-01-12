using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrbisDbgUI {
    public partial class ProcessesForm : Form {
        private MainForm mainForm;

        public ProcessesForm(MainForm mainForm) {
            InitializeComponent();
            this.mainForm = mainForm;

            UpdateProcesses();
        }

        private void ProcessesForm_FormClosed(object sender, FormClosedEventArgs e) {
            mainForm.processesForm = null;
        }

        private void ProcessesForm_Resize(object sender, EventArgs e) {
            ProcessesListDataGridView.Width = this.Width - 17;
            ProcessesListDataGridView.Height = this.Height - 39;
        }

        public void UpdateProcesses() {
            ProcessesListDataGridView.Rows.Clear();
            for (int i = 0; i < mainForm.pList.Count; i++)
                ProcessesListDataGridView.Rows.Add(mainForm.pList[i].name, mainForm.pList[i].pid, mainForm.pList[i].attached);
        }

        private void AttachToProcess(int rowIndex) {
            string processName = ProcessesListDataGridView.Rows[rowIndex].Cells[0].Value.ToString();
            int pid = Convert.ToInt32(ProcessesListDataGridView.Rows[rowIndex].Cells[1].Value);

            mainForm.SelectedProcess = processName;
            OrbisDbg.SetProcess(processName);
            mainForm.SetButtonsEnabled(true);

            if (!Convert.ToBoolean(ProcessesListDataGridView.Rows[rowIndex].Cells[2].Value)) {
                ProcessesListDataGridView.Rows[rowIndex].Cells[2].Value = true;

                for (int i = 0; i < mainForm.pList.Count; i++) {
                    if (mainForm.pList[i].pid == pid) {
                        mainForm.pList[i].attached = 1;
                        break;
                    }
                }

                OrbisDbg.AttachProcess();
            }
        }

        private void DetachFromProcess(int rowIndex) {
            string processName = ProcessesListDataGridView.Rows[rowIndex].Cells[0].Value.ToString();
            int pid = Convert.ToInt32(ProcessesListDataGridView.Rows[rowIndex].Cells[1].Value);

            OrbisDbg.SetProcess(processName);
            if (mainForm.AllowDetach()) {
                mainForm.SetButtonsEnabled(false);

                if (mainForm.memoryForm != null)
                    mainForm.memoryForm.Close();

                if (mainForm.disassemblyForm != null)
                    mainForm.disassemblyForm.Close();

                if (mainForm.breakpointForm != null)
                    mainForm.breakpointForm.Close();

                if (mainForm.registersForm != null)
                    mainForm.registersForm.Close();

                if (Convert.ToBoolean(ProcessesListDataGridView.Rows[rowIndex].Cells[2].Value)) {
                    ProcessesListDataGridView.Rows[rowIndex].Cells[2].Value = false;

                    for (int i = 0; i < mainForm.pList.Count; i++) {
                        if (mainForm.pList[i].pid == pid) {
                            mainForm.pList[i].attached = 0;
                            break;
                        }
                    }

                    OrbisDbg.DetachProcess();
                }
            }
            else {
                MessageBox.Show("Please clear breakpoints before detaching from this process", "Process can't detach");
            }
        }

        private void ProcessesListDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e) {
            if(e.RowIndex > 0) {
                if (e.ColumnIndex == 3)
                    AttachToProcess(e.RowIndex);

                else if (e.ColumnIndex == 4)
                    DetachFromProcess(e.RowIndex);
            }
        }
    }
}
