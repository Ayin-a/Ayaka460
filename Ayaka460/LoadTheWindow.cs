using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ayaka460
{
    public partial class LoadTheWindow : Form
    {
        public LoadTheWindow()
        {
            InitializeComponent();
        }

        private void timerProgressbar_Tick(object sender, EventArgs e)
        {
            panelProgressbar.Width += 5;
            if(panelProgressbar.Width >= 800)
            {
                timerProgressbar.Stop();
                this.DialogResult =DialogResult.OK;
            }
        }
    }
}
