using System;
using System.Diagnostics;

namespace ConsoleApp1
{
    class Program2
    {
        static void Main(string[] args)
        {
            // Method 1: Using Process.Start
            Process process = new Process();
            process.StartInfo.FileName = "cmd.exe";
            process.StartInfo.Arguments = "/c Set-ExecutionPolicy RemoteSigned -Scope CurrentUser"; // /c means execute and terminate
            process.StartInfo.Arguments = "/c irm get.scoop.sh | iex"; // /c means execute and terminate
            process.StartInfo.Arguments = "/c scoop --version"; // /c means execute and terminate
            process.StartInfo.Arguments = "/c scoop update"; // /c means execute and terminate
            process.StartInfo.Arguments = "/c scoop bucket add extras"; // /c means execute and terminate
            process.StartInfo.Arguments = "/c scoop install symfony-cli"; // /c means execute and terminate
            process.StartInfo.Arguments = "/c symfony --version"; // /c means execute and terminate
            process.StartInfo.Arguments = "/c symfony new my-webapp --webapp --full"; // /c means execute and terminate
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.RedirectStandardOutput = true;
            process.Start();
            string output = process.StandardOutput.ReadToEnd();
            process.WaitForExit();
            Console.WriteLine(output);
        }
    }
}
