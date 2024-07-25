namespace Ayaka460
{
    partial class Page1
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

        #region 组件设计器生成的代码

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.GenshinFolders = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Start = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // GenshinFolders
            // 
            this.GenshinFolders.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GenshinFolders.Location = new System.Drawing.Point(-3, 167);
            this.GenshinFolders.Name = "GenshinFolders";
            this.GenshinFolders.Size = new System.Drawing.Size(767, 14);
            this.GenshinFolders.TabIndex = 1;
            this.GenshinFolders.TextChanged += new System.EventHandler(this.GenshinFolders_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "您的原神文件夹位置是:";
            // 
            // Start
            // 
            this.Start.Location = new System.Drawing.Point(59, 260);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(534, 57);
            this.Start.TabIndex = 3;
            this.Start.Text = "点我一键启动";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(59, 194);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(534, 60);
            this.button1.TabIndex = 4;
            this.button1.Text = "选择原神文件夹位置";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Page1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = global::Ayaka460.Properties.Resources._1;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GenshinFolders);
            this.Name = "Page1";
            this.Size = new System.Drawing.Size(697, 401);
            this.Load += new System.EventHandler(this.Page1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox GenshinFolders;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Button button1;
    }
}
