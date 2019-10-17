using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Diagnostics;
using System.IO;
using System.Text;
using iniHelp;

namespace LuckDraw
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        bool stop_flag = false;
        string appPath = Application.StartupPath;
        string sourceIDFile = Application.StartupPath + "\\sourceList.csv";
        string unLuckIDFile = Application.StartupPath + "\\unLuckList.csv";
        string luckSetFile = Application.StartupPath + "\\luckSet.csv";
        string loadFile;
        List<string> unLuckList = new List<string>();
        List<string> luckList = new List<string>();
        List<string> AluckList = new List<string>();
        List<string> luckSetList = new List<string>();
        int luckNum = 0;
        int aLuckNum = 0;
        int aUnLuckCount = 0;
        string titleStr;
        private CIni ini;
        int unLuckCount=0;
        int LuckCount=0;
        string levelFlag = "0";
        string prizeStr = "00";
        string csvTitleStr = "";
        string AcsvTitleStr = "";
        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.Controls.Add(titleLB);
            titleLB.BackColor = Color.Transparent;
            initReady();
        }
        private void initReady()
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            //test();
            loadUnLuckCsv();
            loadLuckCsv();
            loadSetCsv();
            updateLuckListBox();
            getAunluckCount();
            unLuckCount += aUnLuckCount;
            unpateStatusLB();

            readCFG();
            sw.Stop();
            TimeSpan ts = sw.Elapsed;
            Console.WriteLine("timer:{0}ms", ts.TotalMilliseconds);
        }
        private void readCFG()
        {
            string cfgFile = appPath + "\\config.CFG";
            if (!File.Exists(cfgFile))
            {
                MessageBox.Show("CFG file not exists!");
                return;
            }
            ini = new CIni(cfgFile);
            titleStr = ini.getKeyValue("Config", "Title");
            titleLB.Text = titleStr;
            titleTB.Text = titleStr;
        }
        private void loadUnLuckCsv()
        {
            bool unluckFile_Flag = false;
            loadFile = sourceIDFile;
            if (!File.Exists(sourceIDFile))
            {
                MessageBox.Show("sourceList.csv file not exist!");
                return;
            }
            if (File.Exists(unLuckIDFile))
            {
                loadFile = unLuckIDFile;
                unluckFile_Flag = true;
            }
            sourceFileTB.Text = loadFile;

            unLuckList = new List<string>();
            FileStream fs = new FileStream(loadFile, FileMode.Open, FileAccess.Read, FileShare.None);
            StreamReader sr = new StreamReader(fs, Encoding.GetEncoding(936));


            string str = "";
            string s = Console.ReadLine();
            int i = 0;
            while (!sr.EndOfStream)
            {
                str = sr.ReadLine();
                if (!unluckFile_Flag) str=getSubStr(str);
                if (i > 0)
                {
                    
                    unLuckList.Add(str);
                    // Console.WriteLine("{0}", unLuckList[i-1]);
                }
                else if(i == 0)
                {
                    csvTitleStr = str;
                }
                i += 1;
            }
            sr.Close();
            unLuckCount = unLuckList.Count;
            Console.WriteLine("unLuck count:{0}", unLuckCount.ToString());
        }
        private string getSubStr(string str)
        {
            string bResult = "";
            int index = str.IndexOf(',');
            bResult = str.Substring(index + 1);
            return bResult;
        }
        private void loadLuckCsv()
        {
            string csvName = appPath + "\\luckList.csv";
            if (File.Exists(csvName))
            {
                FileStream fs = new FileStream(csvName, FileMode.Open, FileAccess.Read, FileShare.None);
                StreamReader sr = new StreamReader(fs, System.Text.Encoding.GetEncoding(936));


                string str = "";
                string s = Console.ReadLine();
                int i = 0;
                while (!sr.EndOfStream)
                {
                    str = sr.ReadLine();
                    i += 1;
                }
                sr.Close();
                LuckCount = i-1;
            }
            else
            {
                LuckCount = 0;
            }
            
            Console.WriteLine("Luck count:{0}", LuckCount.ToString());
        }
        private void loadSetCsv()
        {
            if (!File.Exists(luckSetFile))
            {
                MessageBox.Show("luckSet.csv not exists!");
                return;
            }
            luckSetList = new List<string>();
            FileStream fs = new FileStream(luckSetFile, FileMode.Open, FileAccess.Read, FileShare.None);
            StreamReader sr = new StreamReader(fs, System.Text.Encoding.GetEncoding(936));


            string str = "";
            string s = Console.ReadLine();
            int i = 0;
            while (!sr.EndOfStream)
            {
                str = sr.ReadLine();
                if (i > 0)
                {
                    luckSetList.Add(str);
                    Console.WriteLine("{0}", luckSetList[i - 1]);
                }
                i += 1;
            }
            sr.Close();
            Console.WriteLine("luckSet count:{0}", luckSetList.Count.ToString());
            int levelCount = luckSetList.Count;
            levelComBox.Items.Clear();
            for(int k = 0; k < levelCount; k++)
            {
                string[] item = luckSetList[k].Split(',');
                levelComBox.Items.Add(item[0]);
            }
        }
        private void startBtn_Click(object sender, EventArgs e)
        {
            if(startBtn.Text == "开始")
            {
                if(levelComBox.SelectedItem == null)
                {
                    MessageBox.Show("请选择奖项等级！");
                    return;
                }
                prizeStr = prizeTB.Text;
                if(prizeStr == "")
                {
                    MessageBox.Show("请输入奖品名称！");
                    return;
                }
                if(numTB.Text == "")
                {
                    MessageBox.Show("请输入人数！");
                    return;
                }
                bool b = int.TryParse(numTB.Text, out luckNum);
                if (!b)
                {
                    MessageBox.Show("请输入正确的人数！");
                    return;
                }
                if (luckNum > unLuckList.Count)
                {
                    MessageBox.Show("奖池人数过少，不能抽奖！");
                    return;
                }
                showListBox.Items.Clear();
                stop_flag = false;
                readyAitems();
                //luckNum = 10;
                Thread thread = new Thread(new ThreadStart(mainThread));//创建线程
                thread.Start(); //启动线程
                actionUI(false);
                startBtn.Text = "停止";
            }
            else if(startBtn.Text == "停止")
            {
                stop_flag = true;
                startBtn.Text = "开始";
                startBtn.Enabled = false;
            }
        }
        #region Aluck
        private void getAunluckCount()
        {
            string sourceFile = appPath + "\\configSys\\AsourceList.csv";
            string unLuckFile = appPath + "\\configSys\\AunLuckList.csv";
            if (File.Exists(unLuckFile)) sourceFile = unLuckFile;
            else if (!File.Exists(sourceFile)) return;

            List<string> AunLuckList = new List<string>();
            FileStream fs = new FileStream(sourceFile, FileMode.Open, FileAccess.Read, FileShare.None);
            StreamReader sr = new StreamReader(fs, Encoding.GetEncoding(936));


            string str = "";
            string s = Console.ReadLine();
            int i = 0;
            while (!sr.EndOfStream)
            {
                str = sr.ReadLine();
                i += 1;
            }
            sr.Close();
            aUnLuckCount = i-1;
        }
        private void readyAitems()
        {
            string sourceFile = appPath + "\\configSys\\AsourceList.csv";
            string unLuckFile = appPath + "\\configSys\\AunLuckList.csv";
            if (File.Exists(unLuckFile)) sourceFile = unLuckFile;
            else if (!File.Exists(sourceFile)) return;

            List<string> AunLuckList = new List<string>();
            AluckList = new List<string>();
            FileStream fs = new FileStream(sourceFile, FileMode.Open, FileAccess.Read, FileShare.None);
            StreamReader sr = new StreamReader(fs, Encoding.GetEncoding(936));


            string str = "";
            string s = Console.ReadLine();
            int i = 0;
            while (!sr.EndOfStream)
            {
                str = sr.ReadLine();
                if (i > 0)
                {
                    int index = str.IndexOf(',');
                    string levelStr = str.Substring(0, index);
                    if(levelFlag == levelStr)
                    {
                        AluckList.Add(getSubStr(str));
                        //Console.WriteLine("ALuckList:{0}", AluckList[i - 1]);
                    }
                    else
                    {
                        AunLuckList.Add(str);
                    }
                    
                }
                else if (i == 0)
                {
                    AcsvTitleStr = str;
                }
                i += 1;
            }
            sr.Close();
            aLuckNum = AluckList.Count;
            aUnLuckCount = i-1;
            Console.WriteLine("ALuckNum:{0}", aLuckNum.ToString());

            //save aunluck list
            //生成CSV文件
            if (File.Exists(unLuckFile))
            {
                File.Delete(unLuckFile);
            }
            try
            {
                FileStream fsTemp = new FileStream(unLuckFile, FileMode.Append);
                StreamWriter swTemp = new StreamWriter(fsTemp,Encoding.Default);
                swTemp.WriteLine(AcsvTitleStr);
                for (int k = 0; k < AunLuckList.Count; k++)
                {
                    swTemp.WriteLine(AunLuckList[k]);
                }

                swTemp.Close();
                fsTemp.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Save AunLuck CSV ERROR:" + ex.ToString());
                MessageBox.Show("Save AunLuck CSV ERROR:" + ex.ToString());
            }
        }
        #endregion

        private void actionUI(bool flag)
        {
            levelComBox.Enabled = flag;
            prizeTB.Enabled = flag;
            numTB.Enabled = flag;
            saveBtn.Enabled = flag;
        }
        private void mainThread()
        {
            int IDcount = unLuckList.Count;
            int[] IDindexArr=new int[IDcount];

            for (int j = 0; j < IDcount; j++)
            {
                IDindexArr[j] = j;
            }
            int i = 0;
            int refreshCount = 0;
            while (!stop_flag)
            {
                i += 1;
                refreshCount += 1;
                Delay(5);
                IDindexArr = (from c in IDindexArr
                              orderby Guid.NewGuid()
                                  select c).ToArray<int>();
                if(refreshCount == 10)
                {
                    printLuckIDs(IDindexArr);
                    refreshCount = 0;
                }
                
                Console.WriteLine("main thread doing...{0}",i.ToString());
            }
            //***************Aluck****************
            luckNum = luckNum - aLuckNum;

            //*******************************
            printLuckIDs(IDindexArr);
            printAluckList();
            //save luck list
            luckList = new List<string>();
            for (int k = 0; k < luckNum; k++)
            {
                luckList.Add(unLuckList[IDindexArr[k]]);
            }
            for (int k = 0; k < aLuckNum; k++)
            {
                luckList.Add(AluckList[k]);
                Console.WriteLine("lucklist add:{0}", AluckList[k]);
            }
            SaveLuckList();
            //change unluck list
            List<string> backupList = unLuckList;
            unLuckList = new List<string>();
            int[] luckIndexArr =new int[luckNum];
            for(int l = 0; l < luckNum; l++)
            {
                luckIndexArr[l] = IDindexArr[l];
            }
            for(int k = 0; k < IDcount; k++)
            {
                if (!checkIndex(k, luckIndexArr)) unLuckList.Add(backupList[k]);
                //Console.WriteLine("remove index:{0}", IDindexArr[k]);
            }
            Console.WriteLine("unluck count:{0}", unLuckList.Count.ToString());
            SaveUnluckList();

            finishUpdateUI();
            showDialogWindow();
            Console.WriteLine("main thread finish");
        }
        private void finishUpdateUI()
        {
            unLuckCount -= (luckNum +aLuckNum);
            LuckCount += (luckNum + aLuckNum);
            Invoke((EventHandler)(delegate
            { 
                unpateStatusLB();
                updateLuckListBox();
                startBtn.Enabled = true;
                actionUI(true);
                startBtn.Focus();
            }));
        }
        private void showDialogWindow()
        {
            ShowWindow swindow = new ShowWindow
            {
                leveStr=levelFlag,
                prizeString=prizeStr,
                showList = luckList
            };
            swindow.ShowDialog();
        }
        private void unpateStatusLB()
        {
            string yield = "0.00%";
            if (unLuckCount != 0)
            {
                int count = unLuckCount + LuckCount;
                double percent = Convert.ToDouble(LuckCount) / Convert.ToDouble(count);
                 yield = string.Format("{0:0.00%}", percent);//得到5.88%

            }
            statusLB.Text = "奖池剩余人数:" + unLuckCount.ToString() +
                         "， 已获奖:" + LuckCount.ToString() +
                         "， 获奖率:" + yield;
        }
        private bool checkIndex(int index,int[] indexArr)
        {
            bool bResult = false;
            foreach(int i in indexArr)
            {
                if(index == i)
                {
                    bResult = true;
                    break;
                }
            }

            return bResult;
        }
        private void printAluckList()
        {
            Invoke((EventHandler)(delegate {
                //showListBox.Items.Clear();
                for (int k = 0; k < aLuckNum; k++)
                {
                    showListBox.Items.Add(AluckList[k]);
                    Console.WriteLine("Aluck index:{0} level:{1}", k.ToString(), levelFlag);
                }

            }));
        }
        private void printLuckIDs(int[] luckIndexArr)
        {           
            Invoke((EventHandler)(delegate {
                showListBox.Items.Clear();
                for (int k = 0; k < luckNum; k++)
                {
                    showListBox.Items.Add(unLuckList[luckIndexArr[k]]);
                    Console.WriteLine("luck index:{0} level:{1}", luckIndexArr[k].ToString(),levelFlag);
                }
                
            }));
        }
        public static void Delay(int mm)
        {
            DateTime current = DateTime.Now;
            while (current.AddMilliseconds(mm) > DateTime.Now)
            {
                int j = 0;
                for (int i = 0; i < 1000; i++)
                {
                    j += 1;
                }
                Application.DoEvents();
            }
            return;
        }
        private void updateLuckListBox()
        {
            luckListBox.Items.Clear();
            
            string csvName = appPath + "\\luckList.csv";
            List<int> dataList = new List<int>();
            if (File.Exists(csvName))
            {
                FileStream fs = new FileStream(csvName, FileMode.Open, FileAccess.Read, FileShare.None);
                StreamReader sr = new StreamReader(fs, System.Text.Encoding.GetEncoding(936));


                string str = "";
                string s = Console.ReadLine();
                int i = 0;
                while (!sr.EndOfStream)
                {
                    str = sr.ReadLine();
                    luckListBox.Items.Add(str);
                    if (i > 0)
                    {
                        string[] item = str.Split(',');
                        dataList.Add(int.Parse(item[0]));
                    }
                    i += 1;
                }
                sr.Close();
                LuckCount = i - 1;
                updateCountListBox(dataList);
            }
            else
            {
                luckCountListBox.Items.Clear();
                LuckCount = 0;
            }
            Console.WriteLine("Luck count:{0}", LuckCount.ToString());
        }
        private void updateCountListBox(List<int> dataList)
        {
            //  List<int> list = new List<int>() { 12, 12, 13, 13, 14, 15, 15, 15 };
            luckCountListBox.Items.Clear();
            var g = dataList.GroupBy(i => i);

            foreach (var item in g)
            {
                string msg = string.Format("Level:{0} , Count:{1}", item.Key, item.Count());
                luckCountListBox.Items.Add(msg);
                Console.WriteLine(msg);
            }
        }
        #region SAVE CSV
        private void SaveLuckList()
        {

            //生成CSV文件
            string csvName = appPath+ "\\luckList.csv";
            if (!File.Exists(csvName))
            {
                FileStream fsTemp = new FileStream(csvName, FileMode.Create);
                StreamWriter swTemp = new StreamWriter(fsTemp,Encoding.Default);
                swTemp.WriteLine("Level,Prize,"+csvTitleStr);     
                swTemp.Close();
                fsTemp.Close();
            }
            try
            {
                FileStream fsTemp = new FileStream(csvName, FileMode.Append);
                StreamWriter swTemp = new StreamWriter(fsTemp,Encoding.Default);
                for(int i = 0; i < luckNum+aLuckNum; i++)
                {
                    swTemp.WriteLine(levelFlag+","+prizeStr+","+ luckList[i]);
                }
                
                swTemp.Close();
                fsTemp.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Save Luck CSV ERROR:" + ex.ToString());
                MessageBox.Show("Save Luck CSV ERROR:" + ex.ToString());
            }
            Delay(10);
        }
        private void SaveUnluckList()
        {
            //生成CSV文件
            if (File.Exists(unLuckIDFile))
            {
                File.Delete(unLuckIDFile);
            }
            try
            {
                FileStream fsTemp = new FileStream(unLuckIDFile, FileMode.Append);
                StreamWriter swTemp = new StreamWriter(fsTemp,Encoding.Default);
                swTemp.WriteLine(csvTitleStr);
                for (int i = 0; i < unLuckList.Count; i++)
                {
                    swTemp.WriteLine(unLuckList[i]);
                }

                swTemp.Close();
                fsTemp.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Save unLuck CSV ERROR:" + ex.ToString());
                MessageBox.Show("Save unLuck CSV ERROR:" + ex.ToString());
            }
            Delay(10);
        }
        #endregion
        private void FileMove(string sourceFile, string targetPath)
        {
            if (!Directory.Exists(targetPath))
            {
                Directory.CreateDirectory(targetPath);
            }
            FileInfo file = new FileInfo(sourceFile);
            file.MoveTo(targetPath + @"\" + DateTime.Now.ToString("yyyy-MM-dd_HH_mm_ss_")+ file.Name);
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
        private void DeletFile(string fileName)
        {
            if (File.Exists(fileName))
            {
                File.Delete(fileName);
                Console.WriteLine(fileName + " file delete successful");
            }
            else
            {
                Console.WriteLine(fileName + " not exists");
            }
        }
        private void saveBtn_Click(object sender, EventArgs e)
        {
            loadUnLuckCsv();
            titleStr = titleTB.Text;
            titleLB.Text = titleStr;
            ActiveForm.Text = loadFile;
            ini.setKeyValue("Config", "Title", titleStr);
            MessageBox.Show("Save successful!");
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            ActiveForm.Text = loadFile;
        }

        private void sourceFileTB_MouseClick(object sender, MouseEventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                sourceFileTB.Text = openFileDialog1.FileName;
                loadFile = openFileDialog1.FileName;
                Console.WriteLine("Choice file:" + loadFile);
            }
        }
        private void levelComBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            levelChange();
        }
        private void levelChange()
        {
            int index = levelComBox.SelectedIndex;
            Console.WriteLine("select level:{0}", index.ToString());
            string[] item = luckSetList[index].Split(',');
            luckNum = int.Parse(item[1]);
            levelFlag = item[0];
            prizeStr = item[2];
            numTB.Text = luckNum.ToString();
            prizeTB.Text = prizeStr;
        }
        private void ResetBtn_Click(object sender, EventArgs e)
        {
            DeletFile(unLuckIDFile);
            Delay(50);
            string luckFileName = appPath+ "\\luckList.csv";
            DeletFile(luckFileName);
            Delay(50);
            string AunLuckFile = appPath + "\\configSys\\AunLuckList.csv";
            DeletFile(AunLuckFile);
            Delay(50);
            initReady();
            showListBox.Items.Clear();
            levelComBox.SelectedIndex = 0;
            levelChange();
            MessageBox.Show("重新设置OK！");
        }
    }
}
