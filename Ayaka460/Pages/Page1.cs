using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tools;
using System.Windows.Forms;
using Ayaka460.Tools;
using System.IO;

namespace Ayaka460
{
    public partial class Page1 : UserControl
    {
        public Page1()
        {
            InitializeComponent();
            GenshinFolders.Text =File.ReadAllText("Config.ini");
            label1.BackColor = Color.Transparent;
        }

        private void Start_Click(object sender, EventArgs e)
        {
            if (File.Exists(GenshinFolders.Text + @"\GenshinImpact.exe") == false) { MessageBox.Show("原神文件位置不对请重新选择"); };
            Copy copy = new Copy();
            copy.Copyto();
        }

    private void GenshinFolders_TextChanged(object sender, EventArgs e)
        {

            string grade =GenshinFolders.Text ;
            string description;
            switch (grade)
            {
                case "紫梦":
                    description = "撸管大王(bushi)";
                    MessageBox.Show(description);
                    break;
                case "宇宙的终极答案":
                    description = "42";
                    MessageBox.Show(description);
                    break;
                case "114514":
                    description = "好臭啊喂";
                    MessageBox.Show(description);
                    break;
                case "星期四":
                    description = "KFCVME50";
                    MessageBox.Show(description);
                    break;
                case "Ayin":
                    description = "摸鱼ing";
                    MessageBox.Show(description);
                    break;
                case "亡灵暴龙大帝":
                    description = "知己!";
                    MessageBox.Show(description);
                    break;
                case "ERthereal":
                    description = "E总!";
                    MessageBox.Show(description);
                    break;
                case "abc":
                    description = "蜀黍是最靠谱的人!";
                    MessageBox.Show(description);
                    break;
                case "冷清":
                    description = "吉祥物(doge)";
                    MessageBox.Show(description);
                    break;
                case "三叶":
                    description = "艾草!";
                    MessageBox.Show(description);
                    break;
                case "单推":
                    description = "蛋腿(doge)";
                    MessageBox.Show(description);
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var get = new GetFolder();
            try 
            {
                GenshinFolders.Text = get.GetFilePath();
            }
            catch
            {
                GenshinFolders.Text = File.ReadAllText("Config.ini");
            }
        }

        private void Page1_Load(object sender, EventArgs e)
        {
         

        }
    }
}
