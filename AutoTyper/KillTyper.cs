using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace KillProcess
{
    internal class KProcess
    {
        public static void KillTyper()
        {
            /*
            stop the execution of "Typer.exe" process that was started by the application
            the process was started by the buttonStart_Click method
             */
            string currentDirectory = Directory.GetCurrentDirectory();
            string executablePath = Path.Combine(currentDirectory, "Process\\Typer.exe");
            Process[] processes = Process.GetProcessesByName(Path.GetFileNameWithoutExtension(executablePath));
            foreach (Process process in processes)
            {
                process.Kill();
            }
            MessageBox.Show("The typing process was stopped with the CTRL+0 command");
        }
    }
}
