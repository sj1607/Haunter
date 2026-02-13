using Haunter.UserControls;
using System;
using System.Collections;
using System.Globalization;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using XDevkit;

namespace Haunter.Classes
{
    public static class JRPC
    {
        public static uint connectionId;
        public static readonly uint jrpcVersion = 2;

        private static readonly uint Void = 0u;

        private static readonly uint Int = 1u;

        private static readonly uint String = 2u;

        private static readonly uint Float = 3u;

        private static readonly uint Byte = 4u;

        private static readonly uint IntArray = 5u;

        private static readonly uint FloatArray = 6u;

        private static readonly uint ByteArray = 7u;

        private static readonly uint Uint64 = 8u;

        private static readonly uint Uint64Array = 9u;

        public enum ThreadType
        {
            System,
            Title
        }

        private static HashSet<Type> ValidReturnTypes = new HashSet<Type>
    {
        typeof(void),
        typeof(bool),
        typeof(byte),
        typeof(short),
        typeof(int),
        typeof(long),
        typeof(ushort),
        typeof(uint),
        typeof(ulong),
        typeof(float),
        typeof(double),
        typeof(string),
        typeof(bool[]),
        typeof(byte[]),
        typeof(short[]),
        typeof(int[]),
        typeof(long[]),
        typeof(ushort[]),
        typeof(uint[]),
        typeof(ulong[]),
        typeof(float[]),
        typeof(double[]),
        typeof(string[])
    };

        public static bool Connect(this IXboxConsole console, out IXboxConsole Console, string XboxNameOrIP = "default")
        {
            if (XboxNameOrIP == "default")
                XboxNameOrIP = ((IXboxManager)new XboxManager()).DefaultConsole;
            IXboxConsole xboxConsole = (IXboxConsole)((IXboxManager)new XboxManager()).OpenConsole(XboxNameOrIP);
            bool flag = false;
            while (!flag)
            {
                try
                {
                    connectionId = xboxConsole.OpenConnection((string)null);
                    flag = true;
                }
                catch
                {
                    Console = xboxConsole;
                    return false;
                }
            }
            Console = xboxConsole;
            return true;
        }

        public static string ConsoleType(this IXboxConsole console)
        {
            string Command = "consolefeatures ver=" + jrpcVersion + " type=17 params=\"A\\0\\A\\0\\\"";
            string String = SendCommand(console, Command);
            return String.Substring(String.find(" ") + 1);
        }

        public static int find(this string String, string _Ptr)
        {
            if (_Ptr.Length == 0 || String.Length == 0)
                return -1;
            for (int index1 = 0; index1 < String.Length; ++index1)
            {
                if ((int)String[index1] == (int)_Ptr[0])
                {
                    bool flag = true;
                    for (int index2 = 0; index2 < _Ptr.Length; ++index2)
                    {
                        if ((int)String[index1 + index2] != (int)_Ptr[index2])
                            flag = false;
                    }
                    if (flag)
                        return index1;
                }
            }
            return -1;
        }

        public static string GetConsoleID(this IXboxConsole console)
        {
            string String = SendCommand(console, "getconsoleid");
            return String.Substring(String.find(" ") + 1).Replace("consoleid=", "");
        }

        public static string GetCPUKey(this IXboxConsole console)
        {
            string Command = "consolefeatures ver=" + (object)jrpcVersion + " type=10 params=\"A\\0\\A\\0\\\"";
            string String = SendCommand(console, Command);
            return String.Substring(String.find(" ") + 1);
        }

        public static string GetDebugVersion(this IXboxConsole console)
        {
            return SendCommand(console, "dmversion").Replace("200- ", string.Empty);
        }

        public static string GetGamertag(this IXboxConsole console, bool IsDevkit)
        {
            uint address;
            uint XAMGamertagWCHARDevkit = 0x81D44475;
            uint XAMGamertagWCHARRetail = 0x81AA28FD;

            if (IsDevkit)
            {
                address = XAMGamertagWCHARDevkit;
            }
            else
            {
                address = XAMGamertagWCHARRetail;
            }
            byte[] memory = GetMemory(console, address, 30);
            return Encoding.Unicode.GetString(memory);
        }

        public static uint GetKernalVersion(this IXboxConsole console)
        {
            string Command = "consolefeatures ver=" + (object)jrpcVersion + " type=13 params=\"A\\0\\A\\0\\\"";
            string String = SendCommand(console, Command);
            return uint.Parse(String.Substring(String.find(" ") + 1));
        }

        public static byte[] GetMemory(this IXboxConsole console, uint Address, uint Length)
        {
            byte[] Data = new byte[(int)(IntPtr)Length];
            console.DebugTarget.GetMemory(Address, Length, Data, out uint BytesRead);
            console.DebugTarget.InvalidateMemoryCache(true, Address, Length);
            return Data;
        }

        private static byte[] GetMemory1(this IXboxConsole console, uint Address, uint Length)
        {
            byte[] Data = new byte[(int)(IntPtr)Length];
            console.DebugTarget.GetMemory(Address, Length, Data, out uint BytesRead);
            return Data;
        }

        public static byte[] GetMemory2(this IXboxConsole console, uint address, uint length, uint ChunkSize = 0x10000)
        {
            byte[] result = new byte[length];

            for (uint offset = 0; offset < length; offset += ChunkSize)
            {
                uint chunkLength = Math.Min(ChunkSize, length - offset);
                byte[] chunk = console.GetMemory1(address + offset, chunkLength);
                Buffer.BlockCopy(chunk, 0, result, (int)offset, (int)chunkLength);
            }
            console.DebugTarget.InvalidateMemoryCache(true, address, length);
            return result;
        }

        public static byte[] GetMemoryTest(this IXboxConsole console, uint address, uint length, uint ChunkSize = 0x10000) // you can adjust this based on search length....i think
        {
            byte[] result = new byte[length];
            object lockObject = new object();

            Parallel.For(0, (int)Math.Ceiling((double)length / ChunkSize), new ParallelOptions { MaxDegreeOfParallelism = Environment.ProcessorCount },
                i =>
                {
                    uint offset = (uint)(i * ChunkSize);
                    uint chunkLength = Math.Min(ChunkSize, length - offset);
                    byte[] chunk = console.GetMemory1(address + offset, chunkLength);

                    lock (lockObject)
                    {
                        Buffer.BlockCopy(chunk, 0, result, (int)offset, (int)chunkLength);
                    }
                });

            console.DebugTarget.InvalidateMemoryCache(true, address, length);
            return result;
        }

        public static ulong GetOfflineXuidDevKit(this IXboxConsole console, bool IsDevkit)
        {
            uint address;
            uint XAMOfflineXuidDevKit = 0x81D44460;
            uint XAMProfileIDRetail = 0x81AA28E8;

            if (IsDevkit)
            {
                address = XAMOfflineXuidDevKit;
            }
            else address = XAMProfileIDRetail;
            return ReadUInt64(console, address);
        }

        public static void Push(this byte[] InArray, out byte[] OutArray, byte Value)
        {
            OutArray = new byte[InArray.Length + 1];
            InArray.CopyTo((Array)OutArray, 0);
            OutArray[InArray.Length] = Value;
        }

        public static float ReadFloat(this IXboxConsole console, uint Address)
        {
            byte[] memory = console.GetMemory2(Address, 4U);
            ReverseBytes(memory, 4);
            return BitConverter.ToSingle(memory, 0);
        }

        public static byte ReadByte(this IXboxConsole console, uint Address)
        {
            return console.GetMemory2(Address, 1U)[0];
        }

        public static string ReadString(this IXboxConsole console, uint Address, uint size)
        {
            return Encoding.UTF8.GetString(console.GetMemory2(Address, size));
        }

        public static ushort ReadUInt16(this IXboxConsole console, uint Address)
        {
            byte[] memory = console.GetMemory2(Address, 2U);
            ReverseBytes(memory, 2);
            return BitConverter.ToUInt16(memory, 0);
        }

        public static uint ReadUInt32(this IXboxConsole console, uint Address)
        {
            byte[] memory = console.GetMemory2(Address, 4U);
            ReverseBytes(memory, 4);
            return BitConverter.ToUInt32(memory, 0);
        }

        public static ulong ReadUInt64(this IXboxConsole console, uint Address)
        {
            byte[] memory = console.GetMemory2(Address, 8U);
            ReverseBytes(memory, 8);
            return BitConverter.ToUInt64(memory, 0);
        }

        private static void ReverseBytes(byte[] buffer, int groupSize)
        {
            if (buffer.Length % groupSize != 0)
                throw new ArgumentException("Group size must be a multiple of the buffer length");
            int num1 = 0;
            while (num1 < buffer.Length)
            {
                int index1 = num1;
                for (int index2 = num1 + groupSize - 1; index1 < index2; --index2)
                {
                    byte num2 = buffer[index1];
                    buffer[index1] = buffer[index2];
                    buffer[index2] = num2;
                    ++index1;
                }
                num1 += groupSize;
            }
        }

        public static string SendCommand(this IXboxConsole console, string Command)
        {
            string Response;
            try
            {
                console.SendTextCommand(connectionId, Command, out Response);
                if (Response.Contains("error="))
                    throw new Exception(Response.Substring(11));
                if (Response.Contains("DEBUG"))
                    throw new Exception("JRPC2 is not installed on the current console");
            }
            catch (COMException ex)
            {
                if (ex.ErrorCode == UIntToInt(2195324935U))
                    throw new Exception("JRPC2 is not installed on the current console");
                throw ex;
            }
            return Response;
        }

        public static void SetMemory(this IXboxConsole console, uint Address, byte[] Data)
        {
            uint BytesWritten;
            console.DebugTarget.SetMemory(Address, (uint)Data.Length, Data, out BytesWritten);
        }

        public static void ShutDownConsole(this IXboxConsole console)
        {
            string Command = "consolefeatures ver=" + (object)jrpcVersion + " type=11 params=\"A\\0\\A\\0\\\"";
            SendCommand(console, Command);
        }

        public static int UIntToInt(uint Value)
        {
            return BitConverter.ToInt32(BitConverter.GetBytes(Value), 0);
        }

        public static void WriteByte(this IXboxConsole console, uint Address, byte Value)
        {
            console.SetMemory(Address, new byte[1] { Value });
        }

        public static void WriteByte(this IXboxConsole console, uint Address, byte[] Value)
        {
            console.SetMemory(Address, Value);
        }

        public static void WriteFloat(this IXboxConsole console, uint Address, float Value)
        {
            byte[] bytes = BitConverter.GetBytes(Value);
            Array.Reverse((Array)bytes);
            console.SetMemory(Address, bytes);
        }

        public static void WriteUInt16(this IXboxConsole console, uint Address, ushort Value)
        {
            byte[] bytes = BitConverter.GetBytes(Value);
            ReverseBytes(bytes, 2);
            console.SetMemory(Address, bytes);
        }

        public static void WriteUInt32(this IXboxConsole console, uint Address, uint Value)
        {
            byte[] bytes = BitConverter.GetBytes(Value);
            ReverseBytes(bytes, 4);
            console.SetMemory(Address, bytes);
        }

        public static void WriteUInt64(this IXboxConsole console, uint Address, ulong Value)
        {
            byte[] bytes = BitConverter.GetBytes(Value);
            ReverseBytes(bytes, 8);
            console.SetMemory(Address, bytes);
        }

        public static void WriteString(this IXboxConsole console, uint Address, string String)
        {
            byte[] OutArray = new byte[0];
            foreach (byte num in String)
                OutArray.Push(out OutArray, num);
            OutArray.Push(out OutArray, (byte)0);
            console.SetMemory(Address, OutArray);
        }

        public static uint XamGetCurrentTitleId(this IXboxConsole console)
        {
            string Command = "consolefeatures ver=" + jrpcVersion + " type=16 params=\"A\\0\\A\\0\\\"";
            string String = SendCommand(console, Command);
            return uint.Parse(String.Substring(String.find(" ") + 1), NumberStyles.HexNumber);
        }

        public static string XboxIP(this IXboxConsole console)
        {
            byte[] bytes = BitConverter.GetBytes(console.IPAddress);
            Array.Reverse((Array)bytes);
            return new IPAddress(bytes).ToString();
        }

        public static void XNotify(this IXboxConsole console, string Text, uint Type)
        {
            string command = string.Concat(new object[]
            {
                "consolefeatures ver=", jrpcVersion, " type=12 params=\"A\\0\\A\\2\\",2,"/",Text.Length,"\\",Text.ToHexString(),"\\",1,"\\",Type,"\\\""
            });
            JRPC.SendCommand(console, command);
        }
        public static string ToHexString(this string String)
        {
            string text = "";
            for (int i = 0; i < String.Length; i++)
            {
                text += ((byte)String[i]).ToString("X2");
            }
            return text;
        }

        private static uint TypeToType<T>(bool Array) where T : struct
        {
            Type typeFromHandle = typeof(T);
            if ((object)typeFromHandle == typeof(int) || (object)typeFromHandle == typeof(uint) || (object)typeFromHandle == typeof(short) || (object)typeFromHandle == typeof(ushort))
            {
                if (Array)
                {
                    return IntArray;
                }

                return Int;
            }

            if ((object)typeFromHandle == typeof(string) || (object)typeFromHandle == typeof(char[]))
            {
                return String;
            }

            if ((object)typeFromHandle == typeof(float) || (object)typeFromHandle == typeof(double))
            {
                if (Array)
                {
                    return FloatArray;
                }

                return Float;
            }

            if ((object)typeFromHandle == typeof(byte) || (object)typeFromHandle == typeof(char))
            {
                if (Array)
                {
                    return ByteArray;
                }

                return Byte;
            }

            if ((object)typeFromHandle == typeof(ulong) || (object)typeFromHandle == typeof(long))
            {
                if (Array)
                {
                    return Uint64Array;
                }

                return Uint64;
            }

            return Uint64;
        }

        internal static ulong ConvertToUInt64(object o)
        {
            if (o is bool)
            {
                if ((bool)o)
                {
                    return 1uL;
                }

                return 0uL;
            }

            if (o is byte)
            {
                return (byte)o;
            }

            if (o is short)
            {
                return (ulong)(short)o;
            }

            if (o is int)
            {
                return (ulong)(int)o;
            }

            if (o is long)
            {
                return (ulong)(long)o;
            }

            if (o is ushort)
            {
                return (ushort)o;
            }

            if (o is uint)
            {
                return (uint)o;
            }

            if (o is ulong)
            {
                return (ulong)o;
            }

            if (o is float)
            {
                return (ulong)BitConverter.DoubleToInt64Bits((float)o);
            }

            if (o is double)
            {
                return (ulong)BitConverter.DoubleToInt64Bits((double)o);
            }

            return 0uL;
        }

        internal static bool IsValidReturnType(Type t)
        {
            return ValidReturnTypes.Contains(t);
        }

        public static T Call<T>(this IXboxConsole console, uint Address, params object[] Arguments) where T : struct
        {
            return (T)CallArgs(console, SystemThread: true, TypeToType<T>(Array: false), typeof(T), null, 0, Address, 0u, Arguments);
        }

        public static T Call<T>(this IXboxConsole console, string module, int ordinal, params object[] Arguments) where T : struct
        {
            return (T)CallArgs(console, SystemThread: true, TypeToType<T>(Array: false), typeof(T), module, ordinal, 0u, 0u, Arguments);
        }

        public static T Call<T>(this IXboxConsole console, ThreadType Type, uint Address, params object[] Arguments) where T : struct
        {
            return (T)CallArgs(console, Type == ThreadType.System, TypeToType<T>(Array: false), typeof(T), null, 0, Address, 0u, Arguments);
        }

        public static T Call<T>(this IXboxConsole console, ThreadType Type, string module, int ordinal, params object[] Arguments) where T : struct
        {
            return (T)CallArgs(console, Type == ThreadType.System, TypeToType<T>(Array: false), typeof(T), module, ordinal, 0u, 0u, Arguments);
        }

        public static void CallVoid(this IXboxConsole console, uint Address, params object[] Arguments)
        {
            CallArgs(console, SystemThread: true, Void, typeof(void), null, 0, Address, 0u, Arguments);
        }

        public static void CallVoid(this IXboxConsole console, string module, int ordinal, params object[] Arguments)
        {
            CallArgs(console, SystemThread: true, Void, typeof(void), module, ordinal, 0u, 0u, Arguments);
        }

        public static void CallVoid(this IXboxConsole console, ThreadType Type, uint Address, params object[] Arguments)
        {
            CallArgs(console, Type == ThreadType.System, Void, typeof(void), null, 0, Address, 0u, Arguments);
        }

        public static void CallVoid(this IXboxConsole console, ThreadType Type, string module, int ordinal, params object[] Arguments)
        {
            CallArgs(console, Type == ThreadType.System, Void, typeof(void), module, ordinal, 0u, 0u, Arguments);
        }

        private static byte[] IntArrayToByte(int[] iArray)
        {
            byte[] array = new byte[iArray.Length * 4];
            int num = 0;
            int num2 = 0;
            while (num < iArray.Length)
            {
                for (int i = 0; i < 4; i++)
                {
                    array[num2 + i] = BitConverter.GetBytes(iArray[num])[i];
                }

                num++;
                num2 += 4;
            }

            return array;
        }

        private static object CallArgs(IXboxConsole console, bool SystemThread, uint Type, Type t, string module, int ordinal, uint Address, uint ArraySize, params object[] Arguments)
        {
            if (!IsValidReturnType(t))
            {
                throw new Exception(string.Concat(new object[4]
                {
                "Invalid type ",
                t.Name,
                Environment.NewLine,
                "JRPC only supports: bool, byte, short, int, long, ushort, uint, ulong, float, double"
                }));
            }

            uint connectTimeout = (console.ConversationTimeout = 4000000u);
            console.ConnectTimeout = connectTimeout;
            string text = "consolefeatures ver=" + jrpcVersion + " type=" + Type + (SystemThread ? " system" : "") + ((module != null) ? (" module=\"" + module + "\" ord=" + ordinal) : "") + " as=" + ArraySize + " params=\"A\\" + Address.ToString("X") + "\\A\\" + Arguments.Length + "\\";
            if (Arguments.Length > 37)
            {
                throw new Exception("Can not use more than 37 paramaters in a call");
            }

            foreach (object obj in Arguments)
            {
                bool flag = false;
                if (obj is uint)
                {
                    object obj2 = text;
                    text = string.Concat(obj2, Int, "\\", UIntToInt((uint)obj), "\\");
                    flag = true;
                }

                if (obj is int || obj is bool || obj is byte)
                {
                    if (obj is bool)
                    {
                        object obj3 = text;
                        text = string.Concat(obj3, Int, "/", Convert.ToInt32((bool)obj), "\\");
                    }
                    else
                    {
                        object obj4 = text;
                        text = string.Concat(obj4, Int, "\\", (obj is byte) ? Convert.ToByte(obj).ToString() : Convert.ToInt32(obj).ToString(), "\\");
                    }

                    flag = true;
                }
                else if (obj is int[] || obj is uint[])
                {
                    byte[] array = IntArrayToByte((int[])obj);
                    object obj5 = text;
                    text = string.Concat(obj5, ByteArray.ToString(), "/", array.Length, "\\");
                    for (int j = 0; j < array.Length; j++)
                    {
                        text += array[j].ToString("X2");
                    }

                    text += "\\";
                    flag = true;
                }
                else if (obj is string)
                {
                    string text2 = (string)obj;
                    object obj6 = text;
                    text = string.Concat(obj6, ByteArray.ToString(), "/", text2.Length, "\\", ((string)obj).ToHexString(), "\\");
                    flag = true;
                }
                else if (obj is double num2)
                {
                    string text3 = text;
                    text = text3 + Float + "\\" + num2 + "\\";
                    flag = true;
                }
                else if (obj is float num3)
                {
                    string text3 = text;
                    text = text3 + Float + "\\" + num3 + "\\";
                    flag = true;
                }
                else if (obj is float[])
                {
                    float[] array2 = (float[])obj;
                    string text3 = text;
                    text = text3 + ByteArray + "/" + array2.Length * 4 + "\\";
                    for (int k = 0; k < array2.Length; k++)
                    {
                        byte[] bytes = BitConverter.GetBytes(array2[k]);
                        Array.Reverse(bytes);
                        for (int l = 0; l < 4; l++)
                        {
                            text += bytes[l].ToString("X2");
                        }
                    }

                    text += "\\";
                    flag = true;
                }
                else if (obj is byte[])
                {
                    byte[] array3 = (byte[])obj;
                    object obj2 = text;
                    text = string.Concat(obj2, ByteArray.ToString(), "/", array3.Length, "\\");
                    for (int m = 0; m < array3.Length; m++)
                    {
                        text += array3[m].ToString("X2");
                    }

                    text += "\\";
                    flag = true;
                }

                if (!flag)
                {
                    string text3 = text;
                    text = text3 + Uint64 + "\\" + ConvertToUInt64(obj) + "\\";
                }
            }

            text += "\"";
            string text4 = SendCommand(console, text);
            string text5 = "buf_addr=";
            while (text4.Contains(text5))
            {
                Thread.Sleep(250);
                text4 = SendCommand(console, "consolefeatures " + text5 + "0x" + uint.Parse(text4.Substring(text4.find(text5) + text5.Length), NumberStyles.HexNumber).ToString("X"));
            }

            console.ConversationTimeout = 2000u;
            console.ConnectTimeout = 5000u;
            switch (Type)
            {
                case 1u:
                    {
                        uint num4 = uint.Parse(text4.Substring(text4.find(" ") + 1), NumberStyles.HexNumber);
                        if ((object)t == typeof(uint))
                        {
                            return num4;
                        }

                        if ((object)t == typeof(int))
                        {
                            return UIntToInt(num4);
                        }

                        if ((object)t == typeof(short))
                        {
                            return short.Parse(text4.Substring(text4.find(" ") + 1), NumberStyles.HexNumber);
                        }

                        if ((object)t == typeof(ushort))
                        {
                            return ushort.Parse(text4.Substring(text4.find(" ") + 1), NumberStyles.HexNumber);
                        }

                        break;
                    }
                case 2u:
                    {
                        string text6 = text4.Substring(text4.find(" ") + 1);
                        if ((object)t == typeof(string))
                        {
                            return text6;
                        }

                        if ((object)t == typeof(char[]))
                        {
                            return text6.ToCharArray();
                        }

                        break;
                    }
                case 3u:
                    if ((object)t == typeof(double))
                    {
                        return double.Parse(text4.Substring(text4.find(" ") + 1));
                    }

                    if ((object)t == typeof(float))
                    {
                        return float.Parse(text4.Substring(text4.find(" ") + 1));
                    }

                    break;
                case 4u:
                    {
                        byte b = byte.Parse(text4.Substring(text4.find(" ") + 1), NumberStyles.HexNumber);
                        if ((object)t == typeof(byte))
                        {
                            return b;
                        }

                        if ((object)t == typeof(char))
                        {
                            return (char)b;
                        }

                        break;
                    }
                case 8u:
                    if ((object)t == typeof(long))
                    {
                        return long.Parse(text4.Substring(text4.find(" ") + 1), NumberStyles.HexNumber);
                    }

                    if ((object)t == typeof(ulong))
                    {
                        return ulong.Parse(text4.Substring(text4.find(" ") + 1), NumberStyles.HexNumber);
                    }

                    break;
            }

            switch (Type)
            {
                case 5u:
                    {
                        string text14 = text4.Substring(text4.find(" ") + 1);
                        int num8 = 0;
                        string text15 = "";
                        uint[] array8 = new uint[8];
                        string text9 = text14;
                        for (int i = 0; i < text9.Length; i++)
                        {
                            char c4 = text9[i];
                            if (c4 != ',' && c4 != ';')
                            {
                                text15 += c4;
                            }
                            else
                            {
                                array8[num8] = uint.Parse(text15, NumberStyles.HexNumber);
                                num8++;
                                text15 = "";
                            }

                            if (c4 == ';')
                            {
                                break;
                            }
                        }

                        return array8;
                    }
                case 6u:
                    {
                        string text12 = text4.Substring(text4.find(" ") + 1);
                        int num7 = 0;
                        string text13 = "";
                        float[] array7 = new float[ArraySize];
                        string text9 = text12;
                        for (int i = 0; i < text9.Length; i++)
                        {
                            char c3 = text9[i];
                            if (c3 != ',' && c3 != ';')
                            {
                                text13 += c3;
                            }
                            else
                            {
                                array7[num7] = float.Parse(text13);
                                num7++;
                                text13 = "";
                            }

                            if (c3 == ';')
                            {
                                break;
                            }
                        }

                        return array7;
                    }
                case 7u:
                    {
                        string text10 = text4.Substring(text4.find(" ") + 1);
                        int num6 = 0;
                        string text11 = "";
                        byte[] array6 = new byte[ArraySize];
                        string text9 = text10;
                        for (int i = 0; i < text9.Length; i++)
                        {
                            char c2 = text9[i];
                            if (c2 != ',' && c2 != ';')
                            {
                                text11 += c2;
                            }
                            else
                            {
                                array6[num6] = byte.Parse(text11);
                                num6++;
                                text11 = "";
                            }

                            if (c2 == ';')
                            {
                                break;
                            }
                        }

                        return array6;
                    }
                default:
                    if (Type == Uint64Array)
                    {
                        string text7 = text4.Substring(text4.find(" ") + 1);
                        int num5 = 0;
                        string text8 = "";
                        ulong[] array4 = new ulong[ArraySize];
                        string text9 = text7;
                        for (int i = 0; i < text9.Length; i++)
                        {
                            char c = text9[i];
                            if (c != ',' && c != ';')
                            {
                                text8 += c;
                            }
                            else
                            {
                                array4[num5] = ulong.Parse(text8);
                                num5++;
                                text8 = "";
                            }

                            if (c == ';')
                            {
                                break;
                            }
                        }

                        if ((object)t == typeof(ulong))
                        {
                            return array4;
                        }

                        if ((object)t == typeof(long))
                        {
                            long[] array5 = new long[ArraySize];
                            for (int n = 0; n < ArraySize; n++)
                            {
                                array5[n] = BitConverter.ToInt64(BitConverter.GetBytes(array4[n]), 0);
                            }

                            return array5;
                        }
                    }

                    if (Type == Void)
                    {
                        return 0;
                    }

                    return ulong.Parse(text4.Substring(text4.find(" ") + 1), NumberStyles.HexNumber);
            }
        }

    }

        
    
}
