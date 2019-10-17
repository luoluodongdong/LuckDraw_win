namespace LuckDraw
{
    partial class ShowWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShowWindow));
            this.label1 = new System.Windows.Forms.Label();
            this.showListBox = new System.Windows.Forms.ListBox();
            this.levelShowLB = new System.Windows.Forms.Label();
            this.OKbtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.prizeLB = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe Print", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(180, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(561, 106);
            this.label1.TabIndex = 1;
            this.label1.Text = "Congratulation!";
            // 
            // showListBox
            // 
            this.showListBox.BackColor = System.Drawing.Color.Red;
            this.showListBox.Font = new System.Drawing.Font("隶书", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.showListBox.FormattingEnabled = true;
            this.showListBox.ItemHeight = 27;
            this.showListBox.Items.AddRange(new object[] {
            "1,2,3",
            "4,5,6"});
            this.showListBox.Location = new System.Drawing.Point(109, 125);
            this.showListBox.Name = "showListBox";
            this.showListBox.Size = new System.Drawing.Size(602, 490);
            this.showListBox.TabIndex = 2;
            // 
            // levelShowLB
            // 
            this.levelShowLB.Font = new System.Drawing.Font("隶书", 42F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.levelShowLB.ForeColor = System.Drawing.Color.Yellow;
            this.levelShowLB.Location = new System.Drawing.Point(745, 143);
            this.levelShowLB.Name = "levelShowLB";
            this.levelShowLB.Size = new System.Drawing.Size(265, 84);
            this.levelShowLB.TabIndex = 3;
            this.levelShowLB.Text = "附加奖";
            // 
            // OKbtn
            // 
            this.OKbtn.Font = new System.Drawing.Font("隶书", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.OKbtn.Location = new System.Drawing.Point(815, 552);
            this.OKbtn.Name = "OKbtn";
            this.OKbtn.Size = new System.Drawing.Size(124, 51);
            this.OKbtn.TabIndex = 0;
            this.OKbtn.Text = "确定";
            this.OKbtn.UseVisualStyleBackColor = true;
            this.OKbtn.Click += new System.EventHandler(this.OKbtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LuckDraw.Properties.Resources._9252150_173941470373_2;
            this.pictureBox1.Location = new System.Drawing.Point(0, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1023, 645);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("隶书", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.Yellow;
            this.label2.Location = new System.Drawing.Point(796, 299);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 45);
            this.label2.TabIndex = 4;
            this.label2.Text = "奖 品:";
            // 
            // prizeLB
            // 
            this.prizeLB.Font = new System.Drawing.Font("隶书", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.prizeLB.ForeColor = System.Drawing.Color.Yellow;
            this.prizeLB.Location = new System.Drawing.Point(782, 362);
            this.prizeLB.Name = "prizeLB";
            this.prizeLB.Size = new System.Drawing.Size(174, 114);
            this.prizeLB.TabIndex = 5;
            this.prizeLB.Text = "2000";
            this.prizeLB.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ShowWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 627);
            this.Controls.Add(this.prizeLB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.OKbtn);
            this.Controls.Add(this.levelShowLB);
            this.Controls.Add(this.showListBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1034, 686);
            this.Name = "ShowWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "Congratulation";
            this.Load += new System.EventHandler(this.ShowWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox showListBox;
        private System.Windows.Forms.Label levelShowLB;
        private System.Windows.Forms.Button OKbtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label prizeLB;
    }
}