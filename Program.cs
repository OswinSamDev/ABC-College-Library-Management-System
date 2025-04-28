using System;
using System.Windows.Forms;

namespace ABCCollegeLibrary
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginForm()); // Starts with LoginForm
        }
    }
}
