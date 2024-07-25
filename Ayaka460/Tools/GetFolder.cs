using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tools
{
    internal class GetFolder
    {
        string file = "Config.ini";
        string ConfigPath = "./Config.ini";
        string configContent = null; //创建空类型进行初始化
        public string GetFilePath()
        {
            //用来检测文件是否存在
            if (File.Exists(file) == false) File.Create(file).Close();
            string Check = File.ReadAllText(file);//获取文件内容
            var GetPath = Get();
            if(File.Exists(GetPath + @"\GenshinImpact.exe") == false)
            {
                MessageBox.Show("原神文件位置不对请重新选择");
                throw new Exception();
            }
            return File.ReadAllText(file);
        }
        private string Get()
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.Description = "请选择4.6原神文件夹所在位置";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                if (File.Exists(dialog.SelectedPath + @"\GenshinImpact.exe") != false)
                {
                    //获取原神的目前并且保存在ini文件中
                    FileStream fs = new FileStream(file, FileMode.Create);
                    fs.Close();
                    configContent = File.ReadAllText(file);
                    configContent = Regex.Replace(configContent, configContent, dialog.SelectedPath);
                    File.WriteAllText(file, configContent);
                    string Check1 = File.ReadAllText(file);
                    return dialog.SelectedPath;
                }
            }
            return null;
        }
    }
}

