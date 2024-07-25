using System;
using ApeFree.ApeForms.Demo;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using ApeFree.ApeForms.Forms.Notifications;
using System.Runtime.CompilerServices;
using ApeFree.ApeForms.Core.Controls;

namespace Ayaka460
{
    //摆个烂用Apefree直接生成ui
    public partial class FrmMain : TemplateForm
    {
        public FrmMain()
        {
            InitializeComponent();
            SideBarData = new List<NavBarGroup>
            {
                //左侧栏的ui设计
                new NavBarGroup("首页")
                {
                    //这里的typeif(Page2)是直接将page2替换为打开的页面所以直接在Page2进行功能的更新就可以了
                    new NavItem("前言?",typeof(Page2)),
                    new NavItem("加入我们",typeof (Page3)),
                },
                //这里Page1 和 Page2搞反了 写时没注意到 
                new NavBarGroup("游玩游戏看这里")
                {
                    new NavItem("点我使用",typeof(Page1)),
                    new NavItem("不会看我",typeof(Page4))
                },
                new NavBarGroup("代理(咕咕咕~)"),
                new NavBarGroup("老版本的blk更能(咕咕咕)")
            };

            TopBarData = new List<TopBarItem>
            { 
             //顶部栏的ui设计
              new TopBarItem("官网" , (Ayaka,GuanWang) => MessageBox.Show("暂时还没有官网QAQ")),//我们暂时没有官网QAQ
              //调用cmd 打开网页链接进行加群操作
              new TopBarItem("QQ主群:835212859" , (Ayaka,QQ) => {
              Process.Start("http://qm.qq.com/cgi-bin/qm/qr?_wv=1027&k=-EMhiSrOn0c4E2H9N0Zfv4tZSjtxwgSW&authKey=4yLq2j9PXhOPaq%2Frc%2BBx2Cs1Bo3%2BaIyLJbVYV8BW1WVqyLJDYebGEDsEYjzbQ4ZX&noverify=0&group_code=835212859");
              Toast.Show("正在为您跳转");
              }),
            };
        }
        //创建组件
        protected override void LoadBottomBar(ControlListBox bottomBar)
        {
            base.LoadBottomBar(bottomBar);

            var linklab = new LinkLabel() { Text = "AyakaTeam Github首页", AutoSize = false, Size = new Size(0, 15), TextAlign = ContentAlignment.MiddleCenter };
            var labContactUs = new Label() { Text = "QQ交流群: 835212859", AutoSize = false, Size = new Size(0, 15), TextAlign = ContentAlignment.MiddleCenter };
            var labCopyright = new Label() { Text = "若知是梦须何醒,不比真如一相会", AutoSize = false, Size = new Size(0, 15), TextAlign = ContentAlignment.MiddleCenter };
            //Click 事件订阅 
            linklab.Click += (s, e) => Process.Start("https://github.com/Ayaka-PS/");
            bottomBar.AddItem(linklab);
            bottomBar.AddItem(labContactUs);
            bottomBar.AddItem(labCopyright);
        }

        private void slideTabControl_Load(object sender, EventArgs e)
        {

        }

    }
}
    
