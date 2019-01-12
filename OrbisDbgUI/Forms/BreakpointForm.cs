using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace OrbisDbgUI {
    public partial class BreakpointForm : Form {
        private MainForm mainForm;

        public BreakpointForm(MainForm mainForm) {
            InitializeComponent();
            this.mainForm = mainForm;

            if(File.Exists(@"OrbisDbg\Breakpoints.bin")) {
                byte[] buffer = File.ReadAllBytes(@"OrbisDbg\Breakpoints.bin");
                int count = buffer.Length / 0x30;

                for (int i = 0; i < count; i++) {
                    byte[] bpoint = new byte[0x30];
                    Array.Copy(buffer, (i * 48), bpoint, 0, 48);
                    mainForm.breakpoints.Add(new Breakpoint(bpoint));

                    BreakpointsDataGridView.Rows.Add(mainForm.breakpoints[i].process, "0x" + mainForm.breakpoints[i].address.ToString("X"), mainForm.breakpoints[i].enabled);
                }
            }
        }

        private void BreakpointForm_Resize(object sender, EventArgs e) {
            BreakpointsDataGridView.Width = this.Width - 17;
            BreakpointsDataGridView.Height = this.Height - 67;
        }

        private void BreakpointForm_FormClosed(object sender, FormClosedEventArgs e) {
            string path = @"OrbisDbg\Breakpoints.bin";

            if (File.Exists(path))
                File.Delete(path);

            if (mainForm.breakpoints.Count > 0) {
                for (int i = 0; i < mainForm.breakpoints.Count; i++) {
                    using (var stream = new FileStream(path, FileMode.Append)) {
                        stream.Write(mainForm.breakpoints[i].GetBytes(), 0, 48);
                    }
                }
            }

            mainForm.breakpointForm = null;
        }

        private void BreakpointsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e) {
            if (e.ColumnIndex == 2 && e.RowIndex >= 0) {
                bool value = !Convert.ToBoolean(BreakpointsDataGridView.Rows[e.RowIndex].Cells[2].Value);
                BreakpointsDataGridView.Rows[e.RowIndex].Cells[2].Value = value;
                mainForm.breakpoints[e.RowIndex].enabled = value;

                if(value) {
                    OrbisDbg.Ext.WriteByte(mainForm.breakpoints[e.RowIndex].address, 0xCC);
                }
                else {
                    OrbisDbg.Ext.WriteByte(mainForm.breakpoints[e.RowIndex].address, mainForm.breakpoints[e.RowIndex].instruction);
                }
            }

            else if (e.ColumnIndex == 3 && e.RowIndex >= 0) {
                if(mainForm.breakpoints[e.RowIndex].enabled)
                    OrbisDbg.Ext.WriteByte(mainForm.breakpoints[e.RowIndex].address, mainForm.breakpoints[e.RowIndex].instruction);

                mainForm.breakpoints.RemoveAt(e.RowIndex);
                BreakpointsDataGridView.Rows.Clear();

                for(int i = 0; i < mainForm.breakpoints.Count; i++)
                    BreakpointsDataGridView.Rows.Add(mainForm.breakpoints[i].process, "0x" + mainForm.breakpoints[i].address.ToString("X"), mainForm.breakpoints[i].enabled);
            }
        }

        private void AddBreakpointButton_Click(object sender, EventArgs e) {
            AddBreakpointForm addBreakpointForm = new AddBreakpointForm(mainForm);
            addBreakpointForm.ShowDialog();

            if (addBreakpointForm.DialogResult == DialogResult.OK) {
                Breakpoint breakpoint = addBreakpointForm.breakpoint;

                if(breakpoint.enabled)
                    OrbisDbg.Ext.WriteByte(breakpoint.address, 0xCC);

                mainForm.breakpoints.Add(breakpoint);
                BreakpointsDataGridView.Rows.Add(breakpoint.process, "0x" + breakpoint.address.ToString("X"), breakpoint.enabled);
            }
        }

        private void RemoveBreakpointsButton_Click(object sender, EventArgs e) {
            for(int i = 0; i < mainForm.breakpoints.Count; i++) {
                if (mainForm.breakpoints[i].enabled)
                    OrbisDbg.Ext.WriteByte(mainForm.breakpoints[i].address, mainForm.breakpoints[i].instruction);
            }

            mainForm.breakpoints.Clear();
            BreakpointsDataGridView.Rows.Clear();
        }
    }

    public class Breakpoint {
        public string process;
        public ulong address;
        public byte instruction;
        public bool enabled;

        public Breakpoint(string process, ulong address, byte instruction, bool enabled) {
            this.process = process;
            this.address = address;
            this.instruction = instruction;
            this.enabled = enabled;
        }

        public Breakpoint(byte[] fromFile) {
            string process = Encoding.UTF8.GetString(fromFile, 0, 32);
            if (process.IndexOf('\0') != 0)
                process = process.Substring(0, process.IndexOf('\0'));

            this.process = process;
            this.address = BitConverter.ToUInt64(fromFile, 36);
            this.enabled = BitConverter.ToBoolean(fromFile, 46);
            this.instruction = fromFile[44];
        }

        public byte[] GetBytes() {
            byte[] buffer = new byte[0x30]; //48

            if (process == null)
                process = "none";

            Array.Copy(Encoding.UTF8.GetBytes(process), buffer, process.Length);
            Array.Copy(BitConverter.GetBytes(address), 0, buffer, 36, 8);
            Array.Copy(BitConverter.GetBytes(instruction), 0, buffer, 44, 1);
            Array.Copy(BitConverter.GetBytes(enabled), 0, buffer, 46, 1);

            return buffer;
        }
    }
}
