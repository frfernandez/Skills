using System;
using System.Windows.Forms;

namespace Rodonaves
{
    static class RodonavesProgram
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainF());
        }
    }
}
