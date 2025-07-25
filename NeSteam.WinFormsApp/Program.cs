using Core;

namespace NeSteam.WinFormsApp
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Inputs.InputIt();

            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}