using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;     // 소리
using System.IO;        // 파일위치
using Microsoft.Win32;  // 레지스트리
using System.Net;
using System.Diagnostics;

namespace BdBoss
{
    public partial class MainForm : Form
    {
        private string returnStr;
        private DateTime NSpawn;

        private DateTime NAng;

        private bool bCheck;
        private bool bUpCheck;       // 창위로 버튼 눌렸을때 체크

        string sWebSite = "http://lazytitan.dothome.co.kr/BdBossPhp/";

        public MainForm()
        {
            InitializeComponent();          // 윈도우 폼 초기화
        }

        private void Nbtn_Click(object sender, EventArgs e)
        {
            NAng = DateTime.Now;

            NSpawn = NAng + TimeSpan.FromMinutes(30f);      // 현재시간 + 30분

            NSpawnTime.Text = NSpawn.ToString();                // 문자열로 바꿔서 출력
            bCheck = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            RealTime.Text = DateTime.Now.ToString();

            if (DateTime.Now >= NSpawn && bCheck)
            {
                playSimpleSound();      // 소리출력
                bCheck = false;
            }
        }

        private void playSimpleSound()
        {
            SoundPlayer simpleSound = new SoundPlayer(@"./warring.wav");        // soundplayer는 using System.Media; 해줘야댐
            simpleSound.Play();
        }

        private void WindowSetBtn_Click(object sender, EventArgs e)
        {
            if (!bUpCheck)
            {
                WindowSet.Text = "창 위로 취소";
                bUpCheck = true;
                this.TopMost = true;        // TopMost true는 윈도우 창 맨위로
            }
            else
            {
                bUpCheck = false;
                WindowSet.Text = "창 위로";
                this.TopMost = false;
            }
        }

        private void StackBtn_Click(object sender, EventArgs e)
        {
            FormScrp.I.CreateStack();       // form2(강화 스택) 할당받고 아랫줄에서 실행
        }

        private void RegisteryAdd()
        {
            RegistryKey rkey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);     // 레지스트리 등록 키

            //rkey.SetValue("BdBoss", Application.ExecutablePath.ToString());         // 레지스트리 키 이름
            //rkey.DeleteValue("ProgramName");
            rkey.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //String strFolder = System.IO.Directory.GetCurrentDirectory();       // 현제 파일위치 출력

            //Process.Start(System.IO.Directory.GetCurrentDirectory() + "/Update.exe");
            //RegisteryAdd();                 // 레지스트리 등록

            //MessageBox.Show(strFolder);     // 메시지 박스

            timer1.Start();                 // 타이머
            timer1.Interval = 1000;         // 1초

            try
            {
                returnStr = HttpGet(sWebSite + "Output.php");
                label1.Text = returnStr;
            }
            catch
            {
                label1.Text = "인터넷 오류";
            }
        }

        private void MediaBtn_Click(object sender, EventArgs e)
        {
            FormScrp.I.CreateMedia();
        }

        private void WebPlayerBtn_Click(object sender, EventArgs e)
        {
            FormScrp.I.CreateWeb();
        }
        private string HttpGet(string urlStr)
        {
            WebRequest request = WebRequest.Create(urlStr);
            WebResponse response = request.GetResponse();

            Stream dataStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(dataStream);
            return reader.ReadToEnd().Trim();
        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            try
            {
                returnStr = HttpGet(sWebSite + "Output.php");
                label1.Text = returnStr;
            }
            catch
            {
                label1.Text = "인터넷 오류";
            }
        }

        private void Keydown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F12 && !FormScrp.I.bEnablecheck)
            {
                this.Enabled = false;
                FormScrp.I.ButtonOff();
                FormScrp.I.bEnablecheck = true;
            }
            else if (e.KeyCode == Keys.F12 && FormScrp.I.bEnablecheck)
            {
                this.Enabled = true;
                FormScrp.I.ButtonOn();
                FormScrp.I.bEnablecheck = false;
            }
        }
    }
}
