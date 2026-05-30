using System;
using System.Windows.Forms;
using StudentManagementSystem2.Forms;

namespace StudentManagementSystem2
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            // Start application with Login Form
            Application.Run(new LoginForm());
        }
    }
}