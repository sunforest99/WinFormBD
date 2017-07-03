using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;
using System.Xml;
using System.Diagnostics;

namespace Update
{
    public partial class Update : Form
    {
        List<string> lLocalFilename = new List<string>();
        List<string> lLocalVersion = new List<string>();

        List<string> lRemoteFileName = new List<string>();
        List<string> lRemoteVersion = new List<string>();
        public Update()
        {
            InitializeComponent();

        }

        private void Update_Load(object sender, EventArgs e)
        {
            this.Hide();
            Console.WriteLine("업데이트 확인중...");
            XmlRead();
            WebXmlRead();
            Comparison();
        }

        void XmlRead()
        {
            try
            {
                XmlDocument xml = new XmlDocument();

                xml.Load(@"./version.xml");

                XmlNodeList xNodeList = xml.SelectNodes("/datafile/file");

                foreach (XmlNode xn in xNodeList)
                {
                    lLocalFilename.Add(xn["name"].InnerText);
                    lLocalVersion.Add(xn["version"].InnerText);
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void WebXmlRead()
        {
            try
            {
                XmlDocument xml = new XmlDocument();

                xml.Load(@"http://lazytitan.dothome.co.kr/BdFile/version.xml");

                XmlNodeList xNodeList = xml.SelectNodes("/datafile/file");

                foreach (XmlNode xn in xNodeList)
                {
                    lRemoteFileName.Add(xn["name"].InnerText);
                    lRemoteVersion.Add(xn["version"].InnerText);
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void Comparison()
        {
            for (int i = 0; i <= lRemoteFileName.Count; i++)
            {
                if(i == lRemoteFileName.Count)
                {
                    StartFun();
                    break;
                }

                if (lLocalFilename[i] == lRemoteFileName[i] && lLocalVersion[i] != lRemoteVersion[i])
                {
                    Console.WriteLine("파일 다운로드중...");
                    WebClient webcl = new WebClient();
                    webcl.DownloadFile("http://lazytitan.dothome.co.kr/BdFile/" + lRemoteFileName[i], @"./"+lLocalFilename[i]);
                    webcl.DownloadFile("http://lazytitan.dothome.co.kr/BdFile/version.xml", @"./version.xml");
                }
                else
                {
                    StartFun();
                    break;
                }
            }
        }

        void StartFun()
        {
            Console.WriteLine("최신버전 입니다.");
            Process.Start(System.IO.Directory.GetCurrentDirectory() + "/BdBoss.exe");
            Application.Exit();
            Process[] pr = Process.GetProcessesByName("cmd");
            pr[0].Kill();
        }
    }
}
