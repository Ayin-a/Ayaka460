using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Tools
{
    internal class GetFolder
    {
        public string GetFilePath()
        {
            string file = "Config.ini";
            string ConfigPath = "./Config.ini";
            string configContent = null; //创建空类型进行初始化
            //用来检测文件是否存在
            if (File.Exists(file) == false) File.Create(file);
            string Check = File.ReadAllText(file);//获取文件内容
            if (File.Exists(Check + @"\GenshinImpact.exe") == false)
            {
                FolderBrowserDialog dialog = new FolderBrowserDialog();
                dialog.Description = "请选择原神所在文件夹所在文件夹";
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    //获取原神的目前并且保存在ini文件中
                    FileStream fs = new FileStream(file,FileMode.Create);
                    fs.Close();
                    configContent = File.ReadAllText(file);
                    configContent = Regex.Replace(configContent, configContent, dialog.SelectedPath);
                    File.WriteAllText(file, configContent);
                    string Check1 = File.ReadAllText(file);
                    if (File.Exists(Check1 + @"\GenshinImpact.exe") == false)
                    {
                        MessageBox.Show("路径不正确");
                    }
                    return Check1;
                }
            }
            return null;
        }
    }
}
