using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace autopainter
{
    static class app
    {
        //
        // The main entry point for the application.
        //
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new main());
        }
    }
}