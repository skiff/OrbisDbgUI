using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using System.Net;
using System.Net.Sockets;

namespace OrbisDbgUI {
    public static class OrbisDbg {
        public struct registers {
            public ulong r_r15;
            public ulong r_r14;
            public ulong r_r13;
            public ulong r_r12;
            public ulong r_r11;
            public ulong r_r10;
            public ulong r_r9;
            public ulong r_r8;
            public ulong r_rdi;
            public ulong r_rsi;
            public ulong r_rbp;
            public ulong r_rbx;
            public ulong r_rdx;
            public ulong r_rcx;
            public ulong r_rax;
            public uint r_trapno;
            public ushort r_fs;
            public ushort r_gs;
            public uint r_err;
            public ushort r_es;
            public ushort r_ds;
            public ulong r_rip;
            public ulong r_cs;
            public ulong r_rflags;
            public ulong r_rsp;
            public ulong r_ss;
        }
        public enum SIGNALS {
            SIGHUP	= 1,
            SIGINT	= 2,
            SIGQUIT	= 3,
            SIGILL	= 4,
            SIGTRAP	= 5,
            SIGABRT	= 6,
            SIGEMT	= 7,
            SIGFPE	= 8,
            SIGKILL	= 9,
            SIGBUS	= 10,
            SIGSEGV	= 11,
            SIGSYS	= 12,
            SIGPIPE	= 13,
            SIGALRM	= 14,
            SIGTERM	= 15,
            SIGURG	= 16,
            SIGSTOP	= 17,
            SIGTSTP	= 18,
            SIGCONT	= 19,
            SIGCHLD	= 20,
            SIGTTIN	= 21,
            SIGTTOU	= 22,
            SIGIO	= 23,
            SIGXCPU	= 24,
            SIGXFSZ	= 25,
            SIGVTALRM = 26,	
            SIGPROF	= 27,
            SIGWINCH =  28,
            SIGINFO	= 29,
            SIGUSR1 = 30,
            SIGUSR2 = 31,
        };
        public enum PFLAGS {
            P_ATTACHED = 0x800,
            P_STOPPED = 0x20000,
        }

        private static string IPAddress = "";
        private static string ProcessName = "";

        [DllImport(@"OrbisDbg.dll", CallingConvention = CallingConvention.Cdecl)]
        private static extern int ProcessReadMemory(string ip, string process, ulong address, int length, byte[] buffer);

        [DllImport(@"OrbisDbg.dll", CallingConvention = CallingConvention.Cdecl)]
        private static extern int ProcessWriteMemory(string ip, string process, ulong address, int length, byte[] buffer);

        [DllImport(@"OrbisDbg.dll", CallingConvention = CallingConvention.Cdecl)]
        private static extern int ProcessGetList(string ip, byte[] buffer);

        [DllImport(@"OrbisDbg.dll", CallingConvention = CallingConvention.Cdecl)]
        private static extern int ProcessAttach(string ip, string process);

        [DllImport(@"OrbisDbg.dll", CallingConvention = CallingConvention.Cdecl)]
        private static extern int ProcessDetach(string ip, string process);

        [DllImport(@"OrbisDbg.dll", CallingConvention = CallingConvention.Cdecl)]
        private static extern int ProcessContinue(string ip, string process);

        [DllImport(@"OrbisDbg.dll", CallingConvention = CallingConvention.Cdecl)]
        private static extern int ProcessSignal(string ip, string process, int signal);

        [DllImport(@"OrbisDbg.dll", CallingConvention = CallingConvention.Cdecl)]
        private static extern int ProcessGetRegisters(string ip, string process, byte[] buffer);

        [DllImport(@"OrbisDbg.dll", CallingConvention = CallingConvention.Cdecl)]
        private static extern int ProcessSetRegisters(string ip, string process, byte[] buffer);

        [DllImport(@"OrbisDbg.dll", CallingConvention = CallingConvention.Cdecl)]
        private static extern int ProcessSetSingleStep(string ip, string process);

        [DllImport(@"OrbisDbg.dll", CallingConvention = CallingConvention.Cdecl)]
        private static extern int ProcessClearSingleStep(string ip, string process);

        [DllImport(@"OrbisDbg.dll", CallingConvention = CallingConvention.Cdecl)]
        private static extern int ProcessSingleStep(string ip, string process);

        [DllImport(@"OrbisDbg.dll", CallingConvention = CallingConvention.Cdecl)]
        private static extern int ProcessGetFlags(string ip, string process, byte[] buffer);

        [DllImport(@"OrbisDbg.dll", CallingConvention = CallingConvention.Cdecl)]
        private static extern int InjectELF(string ip, string process, byte[] buffer, int size);

        [DllImport(@"OrbisDbg.dll", CallingConvention = CallingConvention.Cdecl)]
        private static extern int RebootConsole(string ip);

        [DllImport(@"OrbisDbg.dll", CallingConvention = CallingConvention.Cdecl)]
        private static extern int EndRPC(string ip);

        public static void SetIP(string ip) {
            IPAddress = ip;
        }

        public static void SetProcess(string process) {
            ProcessName = process;
        }

        private static byte[] getBytes(registers str) {
            int num = Marshal.SizeOf(str);
            byte[] array = new byte[num];
            IntPtr intPtr = Marshal.AllocHGlobal(num);
            Marshal.StructureToPtr(str, intPtr, true);
            Marshal.Copy(intPtr, array, 0, num);
            Marshal.FreeHGlobal(intPtr);
            return array;
        }

        private static T GetStructure<T>(byte[] bytes) {
            GCHandle gCHandle = GCHandle.Alloc(bytes, GCHandleType.Pinned);
            T result = (T)(Marshal.PtrToStructure(gCHandle.AddrOfPinnedObject(), typeof(T)));
            gCHandle.Free();
            return result;
        }

        public static void SendPayload(byte[] bytes) {
            Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            socket.Connect(new IPEndPoint(System.Net.IPAddress.Parse(IPAddress), 9020));
            socket.Send(bytes);
            socket.Close();
        }

        public static int SetMemory(ulong address, byte[] memory) {
            if (IPAddress.Equals("") || ProcessName.Equals(""))
                return 0;

            return ProcessWriteMemory(IPAddress, ProcessName, address, memory.Length, memory);
        }

        public static byte[] GetMemory(ulong address, int length) {
            if (IPAddress.Equals("") || ProcessName.Equals(""))
                return new byte[length];

            byte[] mem = new byte[length];
            ProcessReadMemory(IPAddress, ProcessName, address, length, mem);
            return mem;
        }

        public static List<Process> GetProcessList() {
            if (IPAddress.Equals(""))
                return new List<Process>();

            byte[] processes = new byte[0x1000];
            if (ProcessGetList(IPAddress, processes) == 0)
                return new List<Process>();

            List<Process> list = new List<Process>();

            string name = string.Empty;
            while ((name = Encoding.UTF8.GetString(processes, (list.Count * 40) + 8, 32)) != null) {
                if (name.IndexOf('\0') == 0)
                    break;

                name = name.Substring(0, name.IndexOf('\0'));

                list.Add(new Process(BitConverter.ToInt32(processes, list.Count * 40), BitConverter.ToInt32(processes, (list.Count * 40) + 4), name));
            }

            return list;
        }

        public static int AttachProcess() {
            if (IPAddress.Equals("") || ProcessName.Equals(""))
                return 0;

            return ProcessAttach(IPAddress, ProcessName);
        }

        public static int DetachProcess() {
            if (IPAddress.Equals("") || ProcessName.Equals(""))
                return 0;

            return ProcessDetach(IPAddress, ProcessName);
        }

        public static int ContinueProcess() {
            if (IPAddress.Equals("") || ProcessName.Equals(""))
                return 0;

            return ProcessContinue(IPAddress, ProcessName);
        }

        public static int SendProcessSignal(SIGNALS signal) {
            if (IPAddress.Equals("") || ProcessName.Equals(""))
                return 0;

            return ProcessSignal(IPAddress, ProcessName, (int)signal);
        }

        public static registers GetRegisters() {
            if (IPAddress.Equals("") || ProcessName.Equals(""))
                return default(registers);

            registers regs = default(registers);

            byte[] data = new byte[Marshal.SizeOf<registers>(regs)];
            int ret = ProcessGetRegisters(IPAddress, ProcessName, data);
            if(ret != 0) 
                regs = GetStructure<registers>(data);
    
            return regs;
        }

        public static int SetRegisters(registers regs) {
            if (IPAddress.Equals("") || ProcessName.Equals(""))
                return 0;

            byte[] data = OrbisDbg.getBytes(regs);
            return ProcessSetRegisters(IPAddress, ProcessName, data);
        }

        public static int SetSingleStep() {
            if (IPAddress.Equals("") || ProcessName.Equals(""))
                return 0;

            return ProcessSingleStep(IPAddress, ProcessName);
        }

        public static int ClearSingleStep() {
            if (IPAddress.Equals("") || ProcessName.Equals(""))
                return 0;

            return ProcessClearSingleStep(IPAddress, ProcessName);
        }

        public static int SingleStep() {
            if (IPAddress.Equals("") || ProcessName.Equals(""))
                return 0;

            return ProcessSingleStep(IPAddress, ProcessName);
        }

        public static int GetProcessFlags() {
            if (IPAddress.Equals("") || ProcessName.Equals(""))
                return 0;

            byte[] buffer = new byte[4];
            int ret = ProcessGetFlags(IPAddress, ProcessName, buffer);
            if (ret == 0)
                return Int32.MaxValue;

            return BitConverter.ToInt32(buffer, 0);
        }

        public static bool IsProcessPaused() {
            if (IPAddress.Equals("") || ProcessName.Equals(""))
                return false;

            byte[] buffer = new byte[4];
            int ret = ProcessGetFlags(IPAddress, ProcessName, buffer);
            if (ret != 0) {
                int flags = BitConverter.ToInt32(buffer, 0);
                return (flags & (int)PFLAGS.P_STOPPED) != 0;
            }

            return false;
        }

        public static int InjectELF(byte[] elf, int size) {
            if (IPAddress.Equals("") || ProcessName.Equals(""))
                return 0;

            return InjectELF(IPAddress, ProcessName, elf, size);
        }

        public static int Reboot() {
            if (IPAddress.Equals(""))
                return 0;

            return RebootConsole(IPAddress);
        }

        public static int CloseDebugger() {
            if (IPAddress.Equals(""))
                return 0;

            return EndRPC(IPAddress);
        }

        public static class Ext {
            public static bool ReadBool(ulong offset) {
                byte[] buffer = OrbisDbg.GetMemory(offset, 1);
                return buffer[0] != 0;
            }

            public static byte ReadByte(ulong offset) {
                byte[] buffer = OrbisDbg.GetMemory(offset, 1);
                return buffer[0];
            }

            public static short ReadInt16(ulong offset) {
                byte[] buffer = OrbisDbg.GetMemory(offset, 2);
                return BitConverter.ToInt16(buffer, 0);
            }

            public static int ReadInt32(ulong offset) {
                byte[] buffer = OrbisDbg.GetMemory(offset, 4);
                return BitConverter.ToInt32(buffer, 0);
            }

            public static long ReadInt64(ulong offset) {
                byte[] buffer = OrbisDbg.GetMemory(offset, 8);
                return BitConverter.ToInt64(buffer, 0);
            }

            public static byte[] ReadBytes(ulong offset, int length) {
                byte[] buffer = OrbisDbg.GetMemory(offset, length);
                return buffer;
            }

            public static ushort ReadUInt16(ulong offset) {
                byte[] buffer = OrbisDbg.GetMemory(offset, 2);
                return BitConverter.ToUInt16(buffer, 0);
            }

            public static uint ReadUInt32(ulong offset) {
                byte[] buffer = OrbisDbg.GetMemory(offset, 4);
                return BitConverter.ToUInt32(buffer, 0);
            }

            public static ulong ReadUInt64(ulong offset) {
                byte[] buffer = OrbisDbg.GetMemory(offset, 8);
                return BitConverter.ToUInt64(buffer, 0);
            }

            public static float ReadFloat(ulong offset) {
                byte[] buffer = OrbisDbg.GetMemory(offset, 4);
                return BitConverter.ToSingle(buffer, 0);
            }

            public static float[] ReadFloats(ulong offset, int arrayLength = 3) {
                float[] vec = new float[arrayLength];
                for (int i = 0; i < arrayLength; i++) {
                    byte[] buffer = OrbisDbg.GetMemory(offset + ((uint)i * 4), 4);
                    vec[i] = BitConverter.ToSingle(buffer, 0);
                }
                return vec;
            }

            public static double ReadDouble(ulong offset) {
                byte[] buffer = OrbisDbg.GetMemory(offset, 8);
                return BitConverter.ToDouble(buffer, 0);
            }

            public static string ReadString(ulong offset) {
                int scalesize = 0;
                string str = string.Empty;

                while (!str.Contains("\0")) {
                    byte[] buffer = ReadBytes(offset + (uint)scalesize, 40);
                    str += Encoding.UTF8.GetString(buffer);
                    scalesize += 40;
                }

                return str.Substring(0, str.IndexOf('\0'));
            }

            public static void WriteBool(ulong offset, bool input) {
                byte[] buff = new byte[1];
                buff[0] = input ? (byte)1 : (byte)0;
                OrbisDbg.SetMemory(offset, buff);
            }

            public static void WriteByte(ulong offset, byte input) {
                byte[] buff = new byte[1];
                buff[0] = input;
                OrbisDbg.SetMemory(offset, buff);
            }

            public static void WriteInt16(ulong offset, short input) {
                byte[] buff = new byte[2];
                BitConverter.GetBytes(input).CopyTo(buff, 0);
                OrbisDbg.SetMemory(offset, buff);
            }

            public static void WriteInt32(ulong offset, int input) {
                byte[] buff = new byte[4];
                BitConverter.GetBytes(input).CopyTo(buff, 0);
                OrbisDbg.SetMemory(offset, buff);
            }

            public static void WriteInt64(ulong offset, long input) {
                byte[] buff = new byte[8];
                BitConverter.GetBytes(input).CopyTo(buff, 0);
                OrbisDbg.SetMemory(offset, buff);
            }

            public static void WriteBytes(ulong offset, byte[] input) {
                byte[] buff = input;
                OrbisDbg.SetMemory(offset, buff);
            }

            public static void WriteString(ulong offset, string input) {
                byte[] buff = Encoding.UTF8.GetBytes(input);
                Array.Resize(ref buff, buff.Length + 1);
                OrbisDbg.SetMemory(offset, buff);
            }

            public static void WriteUInt16(ulong offset, ushort input) {
                byte[] buff = new byte[2];
                BitConverter.GetBytes(input).CopyTo(buff, 0);
                OrbisDbg.SetMemory(offset, buff);
            }

            public static void WriteUInt32(ulong offset, uint input) {
                byte[] buff = new byte[4];
                BitConverter.GetBytes(input).CopyTo(buff, 0);
                OrbisDbg.SetMemory(offset, buff);
            }

            public static void WriteUInt64(ulong offset, ulong input) {
                byte[] buff = new byte[8];
                BitConverter.GetBytes(input).CopyTo(buff, 0);
                OrbisDbg.SetMemory(offset, buff);
            }

            public static void WriteFloat(ulong offset, float input) {
                byte[] buff = new byte[4];
                BitConverter.GetBytes(input).CopyTo(buff, 0);
                OrbisDbg.SetMemory(offset, buff);
            }

            public static void WriteFloats(ulong offset, float[] input) {
                byte[] buff = new byte[4];
                for (int i = 0; i < input.Length; i++) {
                    BitConverter.GetBytes(input[i]).CopyTo(buff, 0);
                    OrbisDbg.SetMemory(offset + ((uint)i * 4), buff);
                }
            }

            public static void WriteDouble(ulong offset, double input) {
                byte[] buff = new byte[8];
                BitConverter.GetBytes(input).CopyTo(buff, 0);
                OrbisDbg.SetMemory(offset, buff);
            }
        }
    }

    public class Process {
        public int pid;
        public int attached;
        public string name;

        public Process(int pid, int attached, string name) {
            this.pid = pid;
            this.attached = attached;
            this.name = name;
        }
    }
}
