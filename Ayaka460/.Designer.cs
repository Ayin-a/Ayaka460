namespace Ayaka460
{
    partial class LoadTheWindow
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoadTheWindow));
            this.pictureBoxBackground = new System.Windows.Forms.PictureBox();
            this.panelProgressbarContainer = new System.Windows.Forms.Panel();
            this.panelProgressbar = new System.Windows.Forms.Panel();
            this.timerProgressbar = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBackground)).BeginInit();
            this.panelProgressbarContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxBackground
            // 
            resources.ApplyResources(this.pictureBoxBackground, "pictureBoxBackground");
            this.pictureBoxBackground.Image = global::Ayaka460.Properties.Resources.Ayaka_Bankground;
            this.pictureBoxBackground.Name = "pictureBoxBackground";
            this.pictureBoxBackground.TabStop = false;
            // 
            // panelProgressbarContainer
            // 
            this.panelProgressbarContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(209)))), ((int)(((byte)(248)))));
            this.panelProgressbarContainer.Controls.Add(this.panelProgressbar);
            resources.ApplyResources(this.panelProgressbarContainer, "panelProgressbarContainer");
            this.panelProgressbarContainer.Name = "panelProgressbarContainer";
            // 
            // panelProgressbar
            // 
            this.panelProgressbar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            resources.ApplyResources(this.panelProgressbar, "panelProgressbar");
            this.panelProgressbar.Name = "panelProgressbar";
            // 
            // timerProgressbar
            // 
            this.timerProgressbar.Enabled = true;
            this.timerProgressbar.Interval = 30;
            this.timerProgressbar.Tick += new System.EventHandler(this.timerProgressbar_Tick);
            // 
            // LoadTheWindow
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelProgressbarContainer);
            this.Controls.Add(this.pictureBoxBackground);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoadTheWindow";
            this.ShowInTaskbar = false;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBackground)).EndInit();
            this.panelProgressbarContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxBackground;
        private System.Windows.Forms.Panel panelProgressbarContainer;
        private System.Windows.Forms.Panel panelProgressbar;
        private System.Windows.Forms.Timer timerProgressbar;
    }
}

