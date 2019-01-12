using System;
using System.Runtime.InteropServices;
using System.Text;

namespace OrbisDbgUI {
    class Zydis_NET {
        [DllImport(@"Zydis_NET.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void GetInstructionStringArray(ulong startAddress, byte[] Buffer, int Length, byte[] Out);

        [DllImport(@"Zydis_NET.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern ulong GetInstructionCount(ulong startAddress, byte[] Buffer, int Length);

        private static string CleanInstruction(string instruction) {
            if(instruction.Contains("0x0")) {
                int startIndex = instruction.IndexOf("0x0");
                int endIndex = startIndex + 2;
                while (endIndex < instruction.Length && instruction[endIndex++] == '0') { }

                endIndex--;
                string first = instruction.Substring(0, startIndex + 2);
                string second = instruction.Substring(endIndex);
                instruction = first + second;
            }

            if(instruction.Contains("lea")) {
                int startIndex = instruction.IndexOf("[");
                int endIndex = instruction.IndexOf("]");

                if (startIndex != -1) {
                    string first = instruction.Substring(0, startIndex - 1);
                    string second = instruction.Substring(startIndex + 1, endIndex - startIndex - 1);

                    instruction = first + " " + second;
                }
            }

            return instruction;
        }

        public static string[] GetInstructions(ulong startAddress, byte[] buffer, bool showBytes = true) {
            ulong count = Zydis_NET.GetInstructionCount(startAddress, buffer, buffer.Length);

            byte[] instructionBytes = new byte[count * 128];
            Zydis_NET.GetInstructionStringArray(startAddress, buffer, buffer.Length, instructionBytes);

            string[] instructions = new string[count];

            for(ulong i = 0; i < count; i++) {
                ulong address = BitConverter.ToUInt64(instructionBytes, ((int)i * 128) + 0);
                ulong bytecount = BitConverter.ToUInt64(instructionBytes, ((int)i * 128) + 0x8);
                string bytes = BitConverter.ToString(instructionBytes, ((int)i * 128) + 0x10, (int)bytecount);
                string line = Encoding.UTF8.GetString(instructionBytes, ((int)i * 128) + 0x20, 96);

                if (line.IndexOf('\0') != 0)
                    line = line.Substring(0, line.IndexOf('\0'));

                if(showBytes)
                    instructions[i] = String.Format("0x{0} {1,-35} {2}", address.ToString("X"), bytes, CleanInstruction(line));
                else
                    instructions[i] = String.Format("0x{0} \t {1}", address.ToString("X"), CleanInstruction(line));
            }

            return instructions;
        }
    }
}
