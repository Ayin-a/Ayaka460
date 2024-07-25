using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ayaka460
{
    internal static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            //我也想看到我被反编译
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new LoadTheWindow());
            //如果进度条走完就创建新的窗口
            LoadTheWindow loadTheWindow = new LoadTheWindow();
            if (File.Exists("Config.ini") == false) { File.Create("Config.ini").Close(); }
            if(loadTheWindow.ShowDialog() == DialogResult.OK)
            {
                Application.Run(new FrmMain());
            }
            else
            {
                Application.Exit();
            }
        }
    }
}
