﻿using System;
using System.IO;
using System.Windows.Forms;
using System.Collections.Generic;
using Be.Windows.Forms;

namespace OrbisDbgUI {
    public partial class MemoryForm : Form {
        public MainForm mainForm;
        public Stack<Pointers> pointers = new Stack<Pointers>();

        public byte[] MemoryData = null;
        public ulong address = 0x0;
        public ulong offset = 0x0;

        public MemoryForm(MainForm mainForm) {
            InitializeComponent();
            this.mainForm = mainForm;

            MemoryData = new byte[0x1000];
            MemoryStream stream = new MemoryStream(MemoryData);
            MemoryViewHexBox.ByteProvider = new DynamicFileByteProvider(stream);
        }

        public MemoryForm(MainForm mainForm, byte[] memory) {
            InitializeComponent();
            this.mainForm = mainForm;

            MemoryData = memory;
            MemoryStream stream = new MemoryStream(MemoryData);
            MemoryViewHexBox.ByteProvider = new DynamicFileByteProvider(stream);
        }

        private void MemoryForm_FormClosed(object sender, FormClosedEventArgs e) {
            mainForm.memoryForm = null;
        }

        public void UpdateMemoryView(ulong address, uint size, byte[] memory) {
            this.address = address;
            this.offset = 0;

            AddressToolStripTextBox.Text = "0x" + address.ToString("X");
            LengthToolStripTextBox.Text = "0x" + size.ToString("X");

            MemoryData = memory;
            MemoryStream stream = new MemoryStream(MemoryData);
            MemoryViewHexBox.ByteProvider = new DynamicFileByteProvider(stream);
        }

        private void PeekToolStripButton_Click(object sender, EventArgs e) {
            ulong address = Convert.ToUInt64(AddressToolStripTextBox.Text, 16);
            int size = Convert.ToInt32(LengthToolStripTextBox.Text, 16);

            this.address = address;
            this.offset = 0;

            byte[] memory = OrbisDbg.GetMemory(address, size);

            MemoryData = memory;
            MemoryStream stream = new MemoryStream(MemoryData);
            MemoryViewHexBox.ByteProvider = new DynamicFileByteProvider(stream);
        }

        private void PokeToolStripButton_Click(object sender, EventArgs e) {
            ulong address = Convert.ToUInt64(AddressToolStripTextBox.Text, 16);

            DynamicFileByteProvider dynamicFileByteProvider = MemoryViewHexBox.ByteProvider as DynamicFileByteProvider;
            dynamicFileByteProvider.ApplyChanges();
            OrbisDbg.SetMemory(address, MemoryData);
        }

        private void SaveToolstripButton_Click(object sender, EventArgs e) {
            DynamicFileByteProvider dynamicFileByteProvider = MemoryViewHexBox.ByteProvider as DynamicFileByteProvider;
            dynamicFileByteProvider.ApplyChanges();

            File.WriteAllBytes(@"OrbisDbg\Memory.bin", MemoryData);
        }

        private void MemoryViewHexBox_Click(object sender, EventArgs e) {
            MouseEventArgs me = (MouseEventArgs)e;
            if (me.Button == MouseButtons.Left) 
                offset = (ulong)(MemoryViewHexBox.SelectionStart / 8) * 8;
        }

        private void followPointerToolStripMenuItem_Click(object sender, EventArgs e) {
            ulong previousAddress = 0x0;
            if (pointers.Count > 0)
                previousAddress = pointers.Peek().address;

            pointers.Push(new Pointers(address + offset));

            ulong newAddress = OrbisDbg.Ext.ReadUInt64(address + offset);
            AddressToolStripTextBox.Text = "0x" + newAddress.ToString("X");

            byte[] memory = OrbisDbg.GetMemory(newAddress, Convert.ToInt32(LengthToolStripTextBox.Text, 16));

            MemoryData = memory;
            MemoryStream stream = new MemoryStream(MemoryData);
            MemoryViewHexBox.ByteProvider = new DynamicFileByteProvider(stream);
        }

        private void backtracePointerToolStripMenuItem_Click(object sender, EventArgs e) {
            if(pointers.Count > 0) {
                ulong address = pointers.Pop().address;
                AddressToolStripTextBox.Text = "0x" + address.ToString("X");

                if (address != 0x0) {
                    byte[] memory = OrbisDbg.GetMemory(address, Convert.ToInt32(LengthToolStripTextBox.Text, 16));

                    MemoryData = memory;
                    MemoryStream stream = new MemoryStream(MemoryData);
                    MemoryViewHexBox.ByteProvider = new DynamicFileByteProvider(stream);
                }
            }
        }

        private void ChangeByteLayout_Click(object sender, EventArgs e) {
            if ((ToolStripItem)sender == OneByteToolStripMenuItem)
                MemoryViewHexBox.BytesPerLine = 1;
            if ((ToolStripItem)sender == TwoBytesToolStripMenuItem)
                MemoryViewHexBox.BytesPerLine = 2;
            if ((ToolStripItem)sender == FourBytesToolStripMenuItem)
                MemoryViewHexBox.BytesPerLine = 4;
            if ((ToolStripItem)sender == EightBytesToolStripMenuItem)
                MemoryViewHexBox.BytesPerLine = 8;
            if ((ToolStripItem)sender == FullBytesToolStripMenuItem)
                MemoryViewHexBox.BytesPerLine = 16;

            MemoryViewHexBox.Width = 125 + ((MemoryViewHexBox.BytesPerLine * 2) * 16);
        }

        private void copySelectedToolStripMenuItem_Click(object sender, EventArgs e) {
            MemoryViewHexBox.CopyHex();
        }

        private void MemoryViewHexBox_Copied(object sender, EventArgs e) {
            MemoryViewHexBox.CopyHex();
        }

        private void MemoryForm_Resize(object sender, EventArgs e) {
            MemoryViewHexBox.Width = this.Width - 17;
            MemoryViewHexBox.Height = this.Height - 67;
        }
    }

    public class Pointers {
        public ulong address;

        public Pointers(ulong address) {
            this.address = address;
        }
    }
}
