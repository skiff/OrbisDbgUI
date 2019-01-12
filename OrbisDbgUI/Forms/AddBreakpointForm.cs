using System;
using System.Windows.Forms;

namespace OrbisDbgUI {
    public partial class AddBreakpointForm : Form {
        public MainForm mainForm;
        public Breakpoint breakpoint { get; set; }

        public AddBreakpointForm(MainForm mainForm) {
            InitializeComponent();
            this.mainForm = mainForm;
        }

        private void AddNewBreakpoint_Click(object sender, EventArgs e) {
            ulong address = Convert.ToUInt64(BreakpointAddressTextBox.Text, 16);
            bool enabled = BreakpointEnabledCheckbox.Checked;
            string process = mainForm.SelectedProcess;
            byte instruction = OrbisDbg.Ext.ReadByte(address);

            this.breakpoint = new Breakpoint(process, address, instruction, enabled);

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void CancelButton_Click(object sender, EventArgs e) {
            this.DialogResult = DialogResult.No;
            this.Close();
        }
    }
}
