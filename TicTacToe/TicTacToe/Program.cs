using System;
using System.Windows.Forms;
using TicTacToe.Forms;
using TicTacToe.Managers;

namespace TicTacToe
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var mainForm = new MainForm();
            FormManager.MainForm = mainForm;

            Application.Run(mainForm);
        }
    }
}