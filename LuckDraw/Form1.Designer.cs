namespace LuckDraw
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.startBtn = new System.Windows.Forms.Button();
            this.showListBox = new System.Windows.Forms.ListBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.prizeTB = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numTB = new System.Windows.Forms.TextBox();
            this.levelComBox = new System.Windows.Forms.ComboBox();
            this.statusLB = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.luckCountListBox = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.luckListBox = new System.Windows.Forms.ListBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.sourceFileTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.saveBtn = new System.Windows.Forms.Button();
            this.titleTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.titleLB = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ResetBtn = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // startBtn
            // 
            this.startBtn.Font = new System.Drawing.Font("微软雅黑", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.startBtn.Location = new System.Drawing.Point(690, 278);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(201, 57);
            this.startBtn.TabIndex = 1;
            this.startBtn.Text = "开始";
            this.startBtn.UseVisualStyleBackColor = true;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // showListBox
            // 
            this.showListBox.FormattingEnabled = true;
            this.showListBox.ItemHeight = 24;
            this.showListBox.Location = new System.Drawing.Point(40, 59);
            this.showListBox.Name = "showListBox";
            this.showListBox.Size = new System.Drawing.Size(581, 388);
            this.showListBox.TabIndex = 2;
            // 
            // tabControl1
            // 
            this.tabControl1.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tabControl1.Location = new System.Drawing.Point(0, 159);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(982, 462);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.prizeTB);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.numTB);
            this.tabPage1.Controls.Add(this.levelComBox);
            this.tabPage1.Controls.Add(this.statusLB);
            this.tabPage1.Controls.Add(this.showListBox);
            this.tabPage1.Controls.Add(this.startBtn);
            this.tabPage1.Location = new System.Drawing.Point(34, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(944, 454);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "抽奖";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // prizeTB
            // 
            this.prizeTB.Font = new System.Drawing.Font("微软雅黑", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.prizeTB.Location = new System.Drawing.Point(748, 129);
            this.prizeTB.Name = "prizeTB";
            this.prizeTB.Size = new System.Drawing.Size(152, 38);
            this.prizeTB.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微软雅黑", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(673, 136);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 31);
            this.label7.TabIndex = 8;
            this.label7.Text = "奖品:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(673, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 31);
            this.label4.TabIndex = 7;
            this.label4.Text = "人数:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(670, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 31);
            this.label3.TabIndex = 6;
            this.label3.Text = "等级:";
            // 
            // numTB
            // 
            this.numTB.Font = new System.Drawing.Font("微软雅黑", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.numTB.Location = new System.Drawing.Point(748, 205);
            this.numTB.Name = "numTB";
            this.numTB.Size = new System.Drawing.Size(152, 38);
            this.numTB.TabIndex = 5;
            // 
            // levelComBox
            // 
            this.levelComBox.Font = new System.Drawing.Font("微软雅黑", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.levelComBox.FormattingEnabled = true;
            this.levelComBox.Location = new System.Drawing.Point(748, 59);
            this.levelComBox.Name = "levelComBox";
            this.levelComBox.Size = new System.Drawing.Size(152, 38);
            this.levelComBox.TabIndex = 4;
            this.levelComBox.SelectionChangeCommitted += new System.EventHandler(this.levelComBox_SelectionChangeCommitted);
            // 
            // statusLB
            // 
            this.statusLB.Font = new System.Drawing.Font("微软雅黑", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.statusLB.Location = new System.Drawing.Point(40, 15);
            this.statusLB.Name = "statusLB";
            this.statusLB.Size = new System.Drawing.Size(860, 35);
            this.statusLB.TabIndex = 3;
            this.statusLB.Text = "label3";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.luckCountListBox);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.luckListBox);
            this.tabPage2.Location = new System.Drawing.Point(34, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(944, 454);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "获奖";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // luckCountListBox
            // 
            this.luckCountListBox.FormattingEnabled = true;
            this.luckCountListBox.ItemHeight = 24;
            this.luckCountListBox.Location = new System.Drawing.Point(640, 59);
            this.luckCountListBox.Name = "luckCountListBox";
            this.luckCountListBox.Size = new System.Drawing.Size(274, 388);
            this.luckCountListBox.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(635, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 25);
            this.label6.TabIndex = 2;
            this.label6.Text = "获奖统计:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 25);
            this.label5.TabIndex = 1;
            this.label5.Text = "获奖名单:";
            // 
            // luckListBox
            // 
            this.luckListBox.FormattingEnabled = true;
            this.luckListBox.ItemHeight = 24;
            this.luckListBox.Location = new System.Drawing.Point(6, 59);
            this.luckListBox.Name = "luckListBox";
            this.luckListBox.Size = new System.Drawing.Size(593, 388);
            this.luckListBox.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.ResetBtn);
            this.tabPage3.Controls.Add(this.sourceFileTB);
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Controls.Add(this.saveBtn);
            this.tabPage3.Controls.Add(this.titleTB);
            this.tabPage3.Controls.Add(this.label1);
            this.tabPage3.Location = new System.Drawing.Point(34, 4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(944, 454);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "设置";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // sourceFileTB
            // 
            this.sourceFileTB.Location = new System.Drawing.Point(109, 69);
            this.sourceFileTB.Name = "sourceFileTB";
            this.sourceFileTB.Size = new System.Drawing.Size(788, 31);
            this.sourceFileTB.TabIndex = 4;
            this.sourceFileTB.MouseClick += new System.Windows.Forms.MouseEventHandler(this.sourceFileTB_MouseClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "名单源:";
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(366, 138);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(138, 43);
            this.saveBtn.TabIndex = 2;
            this.saveBtn.Text = "保存";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // titleTB
            // 
            this.titleTB.Location = new System.Drawing.Point(90, 18);
            this.titleTB.Name = "titleTB";
            this.titleTB.Size = new System.Drawing.Size(807, 31);
            this.titleTB.TabIndex = 1;
            this.titleTB.Text = "旺年晚会抽奖";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "标题:";
            // 
            // titleLB
            // 
            this.titleLB.Font = new System.Drawing.Font("Cooper Black", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLB.ForeColor = System.Drawing.Color.LimeGreen;
            this.titleLB.Location = new System.Drawing.Point(0, 31);
            this.titleLB.Name = "titleLB";
            this.titleLB.Size = new System.Drawing.Size(982, 100);
            this.titleLB.TabIndex = 5;
            this.titleLB.Text = "Happy New Year";
            this.titleLB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LuckDraw.Properties.Resources._22964226_140641459000_2;
            this.pictureBox1.Location = new System.Drawing.Point(0, -3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(982, 160);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // ResetBtn
            // 
            this.ResetBtn.Location = new System.Drawing.Point(49, 230);
            this.ResetBtn.Name = "ResetBtn";
            this.ResetBtn.Size = new System.Drawing.Size(127, 38);
            this.ResetBtn.TabIndex = 5;
            this.ResetBtn.Text = "重新抽奖";
            this.ResetBtn.UseVisualStyleBackColor = true;
            this.ResetBtn.Click += new System.EventHandler(this.ResetBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 622);
            this.Controls.Add(this.titleLB);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1001, 669);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.ListBox showListBox;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.TextBox titleTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label titleLB;
        private System.Windows.Forms.TextBox sourceFileTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label statusLB;
        private System.Windows.Forms.ComboBox levelComBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox numTB;
        private System.Windows.Forms.ListBox luckCountListBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox luckListBox;
        private System.Windows.Forms.TextBox prizeTB;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button ResetBtn;
    }
}

