using Software_Project_2_Commiter.Properties;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Software_Project_2_Commiter
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            File.Delete("Bunifu_UI_v1.52.dll");
            File.Delete("Guna.UI2.dll");
            File.WriteAllBytes("Bunifu_UI_v1.52.dll", Resources.Bunifu_UI_v1_52);
            File.WriteAllBytes("Guna.UI2.dll", Resources.Guna_UI2);
            File.SetAttributes("Bunifu_UI_v1.52.dll", FileAttributes.Hidden);
            File.SetAttributes("Guna.UI2.dll", FileAttributes.Hidden);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Main());
        }
    }
}
