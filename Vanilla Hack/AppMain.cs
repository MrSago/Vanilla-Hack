
using System;
using System.Windows.Forms;

namespace Vanilla_Hack
{
    static class AppMain
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}

