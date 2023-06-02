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
    public static IEnumerable<char> ToCharSequance(this SecureString str)
    {
        IntPtr valuePtr = IntPtr.Zero;
        try
        {
            valuePtr = Marshal.SecureStringToBSTR(str);

            for (int i = 0; i < str.Length; i++)
            {
                yield return (char)Marshal.ReadInt16(valuePtr, i * sizeof(char));
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

        foreach (char c in str.ToCharSequance())
        {
            sb.Append(c);
        }

        return sb.ToString();
    }

    public static void AddRange(this SecureString str, IEnumerable<char> chars)
    {
        foreach (char c in chars)
        {
            str.AppendChar(c);
        }
    }

    public static void AddRange(this SecureString @this, SecureString str)
    {
        @this.AddRange(str.ToCharSequance());
    }

}

public static class StringExtention
{
    public static SecureString ToSecureString(this string str)
    {
        SecureString ans = new SecureString();

        ans.AddRange(str);

        return ans;
    }
}