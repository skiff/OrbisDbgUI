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
    public partial class DisassemblyForm : Form {
        public MainForm mainForm;
        public ulong address;
        public byte[] memory;

        private void DisassemblyForm_FormClosing(object sender, FormClosingEventArgs e) {
            mainForm.disassemblyForm = null;
        }

        public DisassemblyForm(MainForm mainForm) {
            InitializeComponent();
            this.mainForm = mainForm;
        }

        public DisassemblyForm(MainForm mainForm, ulong address, byte[] memory) {
            InitializeComponent();
            this.mainForm = mainForm;
            this.address = address;
            this.memory = memory;

            this.DisassemblyAddress.Text = "0x" + address.ToString("X");

            UpdateDisassembly(address, memory);
        }

        private void DisassemblyForm_Resize(object sender, EventArgs e) {
            DisassemblyRichTextBot.Width = this.Width - 17;
            DisassemblyRichTextBot.Height = this.Height - 67;
        }

        public void UpdateDisassembly(ulong address, byte[] memory, bool showBytes = true) {
            this.DisassemblyAddress.Text = "0x" + address.ToString("X");

            string[] disassembly = Zydis_NET.GetInstructions(address, memory, showBytes);

            ShowBytesCheckBox.Checked = showBytes;

            DisassemblyRichTextBot.Clear();
            for (int i = 0; i < disassembly.Length; i++) {
                DisassemblyRichTextBot.AppendText(disassembly[i] + "\n");
            }

            DisassemblyRichTextBot.SelectAll();
            DisassemblyRichTextBot.SelectionColor = Color.Black;

            int firstCharIndex = DisassemblyRichTextBot.GetFirstCharIndexFromLine(0);
            int nextLineIndex = DisassemblyRichTextBot.GetFirstCharIndexFromLine(1);
            int selectionLength = nextLineIndex - firstCharIndex;

            DisassemblyRichTextBot.Select(firstCharIndex, selectionLength);
            DisassemblyRichTextBot.SelectionColor = Color.Blue;
            DisassemblyRichTextBot.SelectionLength = 0;
        }

        public void UpdateDisassemblyKeepMemory(ulong address) {
            int lineWithAddress = 0;
            for (int i = 0; i < DisassemblyRichTextBot.Lines.Length; i++) {
                if (DisassemblyRichTextBot.Lines[i].Contains(address.ToString("X"))) {
                    lineWithAddress = i;
                    break;
                }
            }

            DisassemblyRichTextBot.SelectAll();
            DisassemblyRichTextBot.SelectionColor = Color.Black;

            int firstCharIndex = DisassemblyRichTextBot.GetFirstCharIndexFromLine(lineWithAddress);
            int nextLineIndex = DisassemblyRichTextBot.GetFirstCharIndexFromLine(lineWithAddress + 1);
            int selectionLength = nextLineIndex - firstCharIndex;

            DisassemblyRichTextBot.Select(firstCharIndex, selectionLength);
            DisassemblyRichTextBot.SelectionColor = Color.Blue;
            DisassemblyRichTextBot.SelectionLength = 0;
        }

        private void UpdateDisassemblyToolStripButton_Click(object sender, EventArgs e) {
            ulong address = Convert.ToUInt64(DisassemblyAddress.Text, 16);

            byte[] memory = OrbisDbg.GetMemory(address, 0x200);

            UpdateDisassembly(address, memory, ShowBytesCheckBox.Checked);
        }

        private void ShowBytesCheckBox_CheckedChanged(object sender, EventArgs e) {
            ulong address = Convert.ToUInt64(DisassemblyAddress.Text, 16);

            byte[] memory = OrbisDbg.GetMemory(address, 0x200);

            UpdateDisassembly(address, memory, ShowBytesCheckBox.Checked);
        }

        public void ClearDisassembly() {
            DisassemblyRichTextBot.Clear();
        }

        public bool IsShowingBytes() {
            return ShowBytesCheckBox.Checked;
        }
    }
}
