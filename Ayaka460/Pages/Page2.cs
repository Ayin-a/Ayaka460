using System;
using ApeFree.ApeForms;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ApeFree.ApeForms.Forms.Notifications;
using Ayaka460.Properties;
    namespace Ayaka460
{
    public partial class Page2 : UserControl
    {
        public Page2()
        {
            InitializeComponent();
        }
        //等会写
        private void button1_Click(object sender, EventArgs e)
        {

            Notification.Builder.ShowImageTextNotification(紫梦 =>
            {
                //格式 身份 + 擅长事务 + 加内容 
               紫梦.Title = "紫梦";
               紫梦.RetentionTime = 3000;
               紫梦.Image = Resources.ZiMeng;
            });
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Notification.Builder.ShowImageTextNotification(Ayin =>
            {
                Ayin.Title = "Ayin";
                Ayin.RetentionTime = 3000;
                Ayin.Image = Resources.Ayin;
            });
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Notification.Builder.ShowImageTextNotification(ERthereal =>
            {
                ERthereal.Title = "ERthereal";
                ERthereal.RetentionTime = 3000;
                ERthereal.Image = Resources.ERthereal;
            });
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Notification.Builder.ShowImageTextNotification(abc =>
            {
                abc.Title = "abc";
                abc.RetentionTime = 3000;
                abc.Image = Resources.abc;
            });
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Notification.Builder.ShowImageTextNotification(亡灵暴龙大帝 =>
            {
                亡灵暴龙大帝.Title = "亡灵暴龙大帝";
                亡灵暴龙大帝.RetentionTime = 3000;
                亡灵暴龙大帝.Image = Resources.BaoLong;
            });
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Notification.Builder.ShowImageTextNotification(单推 =>
            {
                单推.Title = "单推";
                单推.RetentionTime = 3000;
                单推.Image = Resources.DanTiao;
            });
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Notification.Builder.ShowImageTextNotification(三叶 =>
            {
                三叶.Title = "三叶";
                三叶.RetentionTime = 3000;
                三叶.Image = Resources.SanYe;
            });
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Notification.Builder.ShowImageTextNotification(冷清 =>
            {
                冷清.Title = "冷清";
                冷清.RetentionTime = 3000;
                冷清.Image = Resources.LengQing;
            });
        }

        private void Page2_Load(object sender, EventArgs e)
        {

        }
    }
}
