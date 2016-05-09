using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MikTexStarter
{
    class Program
    {
        static void Main(string[] args)
        {
         
            Process process = new Process();
            process.StartInfo.FileName = "texify";
            process.StartInfo.Arguments = String.Format("-p -b -q -c HelloWorld.tex");
            process.StartInfo.WorkingDirectory = @"C:\HelloWorldMikTex";
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.RedirectStandardError = true;
            process.StartInfo.UseShellExecute = false;
            process.Start();
            process.WaitForExit();
            if (process.ExitCode == 0)
            {
                Console.WriteLine("Success!");
            }
            else
            {
                Console.WriteLine("Error!");
            }
            Console.ReadKey();
        }
    }
}
