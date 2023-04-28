using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace CourseProjectOpp;

public static class SecureStringExtension
{
    public static IEnumerable<char> GetCharSequance(this SecureString str)
    {
        IntPtr valuePtr = IntPtr.Zero;
        try
        {
            valuePtr = Marshal.SecureStringToBSTR(str);

            for (int i = 0; i < str.Length; i++)
            {
                yield return (char)Marshal.ReadInt16(valuePtr, i * 2);
            }
        }
        finally
        {
            Marshal.ZeroFreeGlobalAllocUnicode(valuePtr);
        }
    }

    public static string ToUnsecureString(this SecureString str)
    {
        StringBuilder sb = new StringBuilder();

        foreach (char c in str.GetCharSequance())
        {
            sb.Append(c);
        }

        return sb.ToString();
    }
}

public static class StringExtention
{
    public static unsafe SecureString ToSecureString(this string str)
    {
        SecureString ans = new SecureString();

        foreach (char c in str)
        {
            ans.AppendChar(c);
        }

        return ans;
    }
}