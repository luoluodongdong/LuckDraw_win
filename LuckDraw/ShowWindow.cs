using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LuckDraw
{
    public partial class ShowWindow : Form
    {
        public ShowWindow()
        {
            InitializeComponent();
        }
        public List<string> showList;
        public string leveStr;
        public string prizeString;
        private void ShowWindow_Load(object sender, EventArgs e)
        {
            pictureBox1.Controls.Add(label1);
            pictureBox1.Controls.Add(levelShowLB);
            pictureBox1.Controls.Add(showListBox);
            pictureBox1.Controls.Add(label2);
            pictureBox1.Controls.Add(prizeLB);
            pictureBox1.Controls.Add(OKbtn);

            label1.BackColor = Color.Transparent;
            levelShowLB.BackColor = Color.Transparent;
            //showListBox.BackColor = pictureBox1.BackColor;
            label2.BackColor = Color.Transparent;
            prizeLB.BackColor = Color.Transparent;
            OKbtn.BackColor = Color.Transparent;

            levelShowLB.Text = getLevelStr(leveStr);
            prizeLB.Text = prizeString;
            showListBox.Items.Clear();
            foreach(string item in showList)
            {
                showListBox.Items.Add(item);

            }
            OKbtn.Focus();
        }
        private string getLevelStr(string leveNum)
        {
            string bResult = "";
            switch (leveNum)
            {
                case "1":
                    bResult = "一等奖";
                    break;
                case "2":
                    bResult = "二等奖";
                    break;
                case "3":
                    bResult = "三等奖";
                    break;
                case "4":
                    bResult = "四等奖";
                    break;
                case "5":
                    bResult = "五等奖";
                    break;
                case "6":
                    bResult = "六等奖";
                    break;
                case "7":
                    bResult = "七等奖";
                    break;
                case "8":
                    bResult = "八等奖";
                    break;
                case "9":
                    bResult = "九等奖";
                    break;
                case "10":
                    bResult = "十等奖";
                    break;
                default:
                    bResult = "附加奖";
                    break;

            }
            return bResult;
        }
        private void OKbtn_Click(object sender, EventArgs e)
        {
            Close();
            Dispose();
        }
    }
}
