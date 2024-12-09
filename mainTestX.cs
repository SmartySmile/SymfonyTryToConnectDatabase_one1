using System;
using System.Diagnostics;

namespace ConsoleApp1
{
    class Program2
    {
        // Helper method to run PowerShell commands
        private static string RunPowerShellCommand(string command)
        {
            Process process = new Process();
            process.StartInfo.FileName = "powershell.exe";
            process.StartInfo.Arguments = $"-Command \"{command}\"";
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.RedirectStandardError = true;
            process.Start();

            string output = process.StandardOutput.ReadToEnd();
            string error = process.StandardError.ReadToEnd();
            process.WaitForExit();

            if (!string.IsNullOrEmpty(error))
            {
                Console.WriteLine($"Error: {error}");
            }

            return output;
        }

        // Main execution
        public static void Main()
        {
            // Run commands sequentially
            var commands = new[]
            {
        "Set-ExecutionPolicy RemoteSigned -Scope CurrentUser",
        "irm get.scoop.sh | iex",
        "scoop --version",
        "scoop update",
        "scoop bucket add extras",
        "scoop install symfony-cli",
        "symfony --version",
        "cd ..",
                "cd ..",
                        "cd ..",
                                "cd ..",
                                        "cd ..",
                                                "cd ..",
                                                        "cd ..",
                                                                "cd ..",
                                                                        "cd ..",
        "symfony new testAppX --webapp --full"
    };

            foreach (var command in commands)
            {
                Console.WriteLine($"Executing: {command}");
                string output = RunPowerShellCommand(command);
                Console.WriteLine(output);
            }
        }
    }
}
