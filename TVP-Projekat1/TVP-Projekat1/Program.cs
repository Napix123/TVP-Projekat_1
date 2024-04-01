using Dash.Forms;
using System;
using System.Windows.Forms;


namespace Dash
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var mainform = new LoginContainer();
            mainform.Show();
            Application.Run();
        }
    }
}
