using System;
using System.Windows.Forms;
using PharmacyManagementSystem.Forms;
using PharmacyManagementSystem.Models;

namespace PharmacyManagementSystem
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Metrics.Stopwatch.Start();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginForm());
        }
    }
}