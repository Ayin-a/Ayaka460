using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Collections;
using System.Windows.Forms;
using System.Diagnostics;

namespace Ayaka460.Tools
{
    internal class Copy
    {

        public void Copyto()
        {
            var Check = File.ReadAllText("Config.ini");
            string newPath1 = Check + @"\version.dll";
            string newPath2 = Check + @"\GenshinImpact_Data\Plugins\mihoyonet.dll";
            try
            {
                //File.Copy(url_txt, newPath, true);
                File.Copy("./Dispatch/version.dll", newPath1, true);
                File.Copy("./Dispatch/mihoyonet.dll", newPath2, true);
                MessageBox.Show("成功了正在打开原神");
                Process.Start(Check + @"\GenshinImpact.exe");
            }
            catch
            {
                MessageBox.Show("不要乱删除文件");
            }
        }
    }
}