using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;

namespace J3534_Tool
{
    public static class NativeMethod
    {
        [DllImport("kernel32.dll", EntryPoint = "LoadLibrary")]
        public static extern IntPtr LoadLibrary([MarshalAs(UnmanagedType.LPStr)] string lpLibFileName);

        [DllImport("kernel32.dll", EntryPoint = "GetProcAddress")]
        public static extern IntPtr GetProcAddress(IntPtr hModule, [MarshalAs(UnmanagedType.LPStr)] string lpProcName);

        [DllImport("kernel32.dll", EntryPoint = "FreeLibrary")]
        public static extern bool FreeLibrary(IntPtr hModule);
    }

    public class DLLSecurityLoad
    {

        int intESWSecurityLevel;

        public int IntESWSecurityLevel
        {
            get { return intESWSecurityLevel; }
            set { intESWSecurityLevel = value; }
        }

        public byte[] LoadDll(string dllPath, byte level, int sizeKey, byte[] requestSeed, int dlltype, int extraByteSize, byte[] extraByte)
        {
            IntPtr hModule = NativeMethod.LoadLibrary(dllPath);
            if (hModule == IntPtr.Zero)
                return null;        //如果dll文件不存在，返回空

            byte[] seedKey = new byte[sizeKey];     //声明seedKey，用于存储返回的key值
            byte[] bytes = new byte[sizeKey];
            uint actual = 0;
            IntPtr intPtr;
            if (dlltype == 0)
            {
                intPtr = NativeMethod.GetProcAddress(hModule, "ES_CalculateKeyFromSeed");
                ES_CalculateKeyFromSeed eS_CalculateKeyFromSeed = (ES_CalculateKeyFromSeed)Marshal.GetDelegateForFunctionPointer(intPtr, typeof(ES_CalculateKeyFromSeed));
                eS_CalculateKeyFromSeed(level, sizeKey, extraByteSize, ref requestSeed[0], ref seedKey[0], ref extraByte[0]);
            }
            else if (dlltype == 1)
            {
                intPtr = NativeMethod.GetProcAddress(hModule, "GenerateKeyExOpt");
                GenerateKeyExOpt generateKeyExOpt = (GenerateKeyExOpt)Marshal.GetDelegateForFunctionPointer(intPtr, typeof(GenerateKeyExOpt));
                generateKeyExOpt(ref requestSeed[0], sizeKey, level, ref bytes[0], ref bytes[0], ref seedKey[0], 8, ref actual);
            }
            else if (dlltype == 2)
            {
                if (intESWSecurityLevel == 0)
                {
                    intPtr = NativeMethod.GetProcAddress(hModule, "CalcKeys");
                    CalcKeys calcKeys = (CalcKeys)Marshal.GetDelegateForFunctionPointer(intPtr, typeof(CalcKeys));
                    calcKeys(ref requestSeed[0], ref seedKey[0], ref bytes[0], ref bytes[0], ref bytes[0]);
                }
                else if (intESWSecurityLevel == 1)
                {
                    intPtr = NativeMethod.GetProcAddress(hModule, "CalcKeys1");
                    CalcKeys1 calcKeys1 = (CalcKeys1)Marshal.GetDelegateForFunctionPointer(intPtr, typeof(CalcKeys1));
                    calcKeys1(ref requestSeed[0], ref seedKey[0], ref bytes[0], ref bytes[0], ref bytes[0]);
                }
                else if (intESWSecurityLevel == 2)
                {
                    intPtr = NativeMethod.GetProcAddress(hModule, "CalcKeys2");
                    CalcKeys2 calcKeys2 = (CalcKeys2)Marshal.GetDelegateForFunctionPointer(intPtr, typeof(CalcKeys1));
                    calcKeys2(ref requestSeed[0], ref seedKey[0], ref bytes[0], ref bytes[0], ref bytes[0]);
                }
                else if (intESWSecurityLevel == 3)
                {
                    intPtr = NativeMethod.GetProcAddress(hModule, "CalcKeys3");
                    CalcKeys3 calcKeys3 = (CalcKeys3)Marshal.GetDelegateForFunctionPointer(intPtr, typeof(CalcKeys1));
                    calcKeys3(ref requestSeed[0], ref seedKey[0], ref bytes[0], ref bytes[0], ref bytes[0]);
                }
                else { }
            }

            else if (dlltype == 3)
            {
                intPtr = NativeMethod.GetProcAddress(hModule, "CalcKeys");
                CalcKeys calcKeys = (CalcKeys)Marshal.GetDelegateForFunctionPointer(intPtr, typeof(CalcKeys));
                calcKeys(ref requestSeed[0], ref seedKey[0], ref bytes[0], ref bytes[0], ref bytes[0]);
            }

            else if (dlltype == 4)
            {
                intPtr = NativeMethod.GetProcAddress(hModule, "CalcKeys1");
                CalcKeys1 calcKeys1 = (CalcKeys1)Marshal.GetDelegateForFunctionPointer(intPtr, typeof(CalcKeys1));
                calcKeys1(ref requestSeed[0], ref seedKey[0], ref bytes[0], ref bytes[0], ref bytes[0]);
            }

            NativeMethod.FreeLibrary(hModule);
            return seedKey;
        }

        public UInt32 LoadChecksumDll(string dllPath, byte[] pBuffer, UInt32 u32Size)
        {
            UInt32 CheckSumResult = 0;
            IntPtr hModule = NativeMethod.LoadLibrary(dllPath);
            if (hModule == IntPtr.Zero)
                return CheckSumResult;        //如果dll文件不存在，返回空
            IntPtr intPtr = NativeMethod.GetProcAddress(hModule, "CalcChecksum");
            CalcChecksum calcChecksum = (CalcChecksum)Marshal.GetDelegateForFunctionPointer(intPtr, typeof(CalcChecksum));
            CheckSumResult = calcChecksum(ref pBuffer[0], u32Size);
            return CheckSumResult;
        }
    }
    delegate bool ES_CalculateKeyFromSeed(byte ucSecurityLevel, int iSeedKeySize, int iExtraByteSize, ref byte pucSeed,
            ref byte pucKey, ref byte pucExtraBytes);

    [UnmanagedFunctionPointerAttribute(CallingConvention.Cdecl)]
    delegate byte GenerateKeyExOpt(ref byte ipSeedArray, int iSeedArraySize, int iSecurityLevel, ref byte ipVariant,
    ref byte ipOptions, ref byte iopKeyArray, int iMaxKeyArraySize, ref uint oActualKeyArraySize);

    [UnmanagedFunctionPointerAttribute(CallingConvention.Cdecl)]
    delegate void CalcKeys(ref byte seed_value, ref byte key_value, ref byte PIN, ref byte Delta, ref byte Constant);

    [UnmanagedFunctionPointerAttribute(CallingConvention.Cdecl)]
    delegate void CalcKeys1(ref byte seed_value, ref byte key_value, ref byte PIN, ref byte Delta, ref byte Constant);

    [UnmanagedFunctionPointerAttribute(CallingConvention.Cdecl)]
    delegate void CalcKeys2(ref byte seed_value, ref byte key_value, ref byte PIN, ref byte Delta, ref byte Constant);

    [UnmanagedFunctionPointerAttribute(CallingConvention.Cdecl)]
    delegate void CalcKeys3(ref byte seed_value, ref byte key_value, ref byte PIN, ref byte Delta, ref byte Constant);

    [UnmanagedFunctionPointerAttribute(CallingConvention.Cdecl)]
    delegate UInt32 CalcChecksum(ref byte pBuffer, UInt32 u32Size);
}
