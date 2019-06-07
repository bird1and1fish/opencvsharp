namespace WindowsFormsApp1
{
    partial class Form1
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.opentoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.savetoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.photoStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.录制视频ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.停止录制ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.videoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.停止播放ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exittoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.编辑ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.动态识别ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.停止识别ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.摄像头设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.开始保存ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.暂停保存ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.继续保存ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.停止保存ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 422);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.textBox1.Location = new System.Drawing.Point(0, 425);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(800, 25);
            this.textBox1.TabIndex = 2;
            // 
            // menuStrip2
            // 
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文件ToolStripMenuItem,
            this.编辑ToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(800, 28);
            this.menuStrip2.TabIndex = 3;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // 文件ToolStripMenuItem
            // 
            this.文件ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opentoolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.savetoolStripMenuItem,
            this.photoStripMenuItem,
            this.录制视频ToolStripMenuItem,
            this.停止录制ToolStripMenuItem,
            this.videoToolStripMenuItem,
            this.停止播放ToolStripMenuItem,
            this.exittoolStripMenuItem});
            this.文件ToolStripMenuItem.Name = "文件ToolStripMenuItem";
            this.文件ToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.文件ToolStripMenuItem.Text = "文件";
            this.文件ToolStripMenuItem.Click += new System.EventHandler(this.文件ToolStripMenuItem_Click);
            // 
            // opentoolStripMenuItem
            // 
            this.opentoolStripMenuItem.Name = "opentoolStripMenuItem";
            this.opentoolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.opentoolStripMenuItem.Text = "打开图片";
            this.opentoolStripMenuItem.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.deleteToolStripMenuItem.Text = "清空图片";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.删除图片ToolStripMenuItem_Click);
            // 
            // savetoolStripMenuItem
            // 
            this.savetoolStripMenuItem.Name = "savetoolStripMenuItem";
            this.savetoolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.savetoolStripMenuItem.Text = "保存图片";
            this.savetoolStripMenuItem.Click += new System.EventHandler(this.savetoolStripMenuItem_Click);
            // 
            // photoStripMenuItem
            // 
            this.photoStripMenuItem.Name = "photoStripMenuItem";
            this.photoStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.photoStripMenuItem.Text = "照相";
            this.photoStripMenuItem.Click += new System.EventHandler(this.opencvsharpToolStripMenuItem_Click);
            // 
            // 录制视频ToolStripMenuItem
            // 
            this.录制视频ToolStripMenuItem.Name = "录制视频ToolStripMenuItem";
            this.录制视频ToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.录制视频ToolStripMenuItem.Text = "录制视频";
            this.录制视频ToolStripMenuItem.Click += new System.EventHandler(this.录制视频ToolStripMenuItem_Click);
            // 
            // 停止录制ToolStripMenuItem
            // 
            this.停止录制ToolStripMenuItem.Name = "停止录制ToolStripMenuItem";
            this.停止录制ToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.停止录制ToolStripMenuItem.Text = "停止录制";
            this.停止录制ToolStripMenuItem.Click += new System.EventHandler(this.停止录制ToolStripMenuItem_Click);
            // 
            // videoToolStripMenuItem
            // 
            this.videoToolStripMenuItem.Name = "videoToolStripMenuItem";
            this.videoToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.videoToolStripMenuItem.Text = "播放视频";
            this.videoToolStripMenuItem.Click += new System.EventHandler(this.videoToolStripMenuItem_Click);
            // 
            // 停止播放ToolStripMenuItem
            // 
            this.停止播放ToolStripMenuItem.Name = "停止播放ToolStripMenuItem";
            this.停止播放ToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.停止播放ToolStripMenuItem.Text = "停止播放";
            this.停止播放ToolStripMenuItem.Click += new System.EventHandler(this.停止播放ToolStripMenuItem_Click);
            // 
            // exittoolStripMenuItem
            // 
            this.exittoolStripMenuItem.Name = "exittoolStripMenuItem";
            this.exittoolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.exittoolStripMenuItem.Text = "退出";
            this.exittoolStripMenuItem.Click += new System.EventHandler(this.toolStripMenuItem4_Click);
            // 
            // 编辑ToolStripMenuItem
            // 
            this.编辑ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.动态识别ToolStripMenuItem,
            this.停止识别ToolStripMenuItem,
            this.摄像头设置ToolStripMenuItem,
            this.开始保存ToolStripMenuItem,
            this.停止保存ToolStripMenuItem,
            this.暂停保存ToolStripMenuItem,
            this.继续保存ToolStripMenuItem});
            this.编辑ToolStripMenuItem.Name = "编辑ToolStripMenuItem";
            this.编辑ToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.编辑ToolStripMenuItem.Text = "编辑";
            // 
            // 动态识别ToolStripMenuItem
            // 
            this.动态识别ToolStripMenuItem.Name = "动态识别ToolStripMenuItem";
            this.动态识别ToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.动态识别ToolStripMenuItem.Text = "动态识别";
            this.动态识别ToolStripMenuItem.Click += new System.EventHandler(this.动态识别ToolStripMenuItem_Click);
            // 
            // 停止识别ToolStripMenuItem
            // 
            this.停止识别ToolStripMenuItem.Name = "停止识别ToolStripMenuItem";
            this.停止识别ToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.停止识别ToolStripMenuItem.Text = "停止识别";
            this.停止识别ToolStripMenuItem.Click += new System.EventHandler(this.停止识别ToolStripMenuItem_Click);
            // 
            // 摄像头设置ToolStripMenuItem
            // 
            this.摄像头设置ToolStripMenuItem.Name = "摄像头设置ToolStripMenuItem";
            this.摄像头设置ToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.摄像头设置ToolStripMenuItem.Text = "摄像头设置";
            this.摄像头设置ToolStripMenuItem.Click += new System.EventHandler(this.摄像头设置ToolStripMenuItem_Click);
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            // 
            // 开始保存ToolStripMenuItem
            // 
            this.开始保存ToolStripMenuItem.Name = "开始保存ToolStripMenuItem";
            this.开始保存ToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.开始保存ToolStripMenuItem.Text = "开始保存";
            this.开始保存ToolStripMenuItem.Click += new System.EventHandler(this.开始保存ToolStripMenuItem_Click);
            // 
            // 暂停保存ToolStripMenuItem
            // 
            this.暂停保存ToolStripMenuItem.Name = "暂停保存ToolStripMenuItem";
            this.暂停保存ToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.暂停保存ToolStripMenuItem.Text = "暂停保存";
            this.暂停保存ToolStripMenuItem.Click += new System.EventHandler(this.暂停保存ToolStripMenuItem_Click);
            // 
            // 继续保存ToolStripMenuItem
            // 
            this.继续保存ToolStripMenuItem.Name = "继续保存ToolStripMenuItem";
            this.继续保存ToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.继续保存ToolStripMenuItem.Text = "继续保存";
            this.继续保存ToolStripMenuItem.Click += new System.EventHandler(this.继续保存ToolStripMenuItem_Click);
            // 
            // 停止保存ToolStripMenuItem
            // 
            this.停止保存ToolStripMenuItem.Name = "停止保存ToolStripMenuItem";
            this.停止保存ToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.停止保存ToolStripMenuItem.Text = "停止保存";
            this.停止保存ToolStripMenuItem.Click += new System.EventHandler(this.停止保存ToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip2;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "图像处理";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem 文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem opentoolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exittoolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem savetoolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem photoStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem videoToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.ToolStripMenuItem 录制视频ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 停止播放ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 编辑ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 动态识别ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 停止识别ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 停止录制ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 摄像头设置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 开始保存ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 暂停保存ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 继续保存ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 停止保存ToolStripMenuItem;
    }
}

