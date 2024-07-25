using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ayaka460
{
    public partial class Page4 : UserControl
    {
        public Page4()
        {
            InitializeComponent();
            button1.BackColor = Color.Transparent;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Process.Start("教程.mp4");
        }

        private void Page4_Load(object sender, EventArgs e)
        {

        }
    }
}
