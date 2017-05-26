using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using SHDocVw;

namespace BdBoss
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void FormClose(object sender, FormClosingEventArgs e)
        {
            webBrowser.Refresh();       // Form4 가 꺼졌을때 웹브라우저 초기화
        }

        private void MoveBtn_Click(object sender, EventArgs e)
        {
            webBrowser.Navigate(Address.Text);      // 사이트 주소 넣어줌
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            System.Windows.Forms.HtmlDocument document = this.webBrowser.Document;  // 자바스크립트 개객기
            //InternetExplorer ex = new InternetExplorer();
            //ex.Visible = true;
            //ex.Navigate("ani.today");
            this.TopMost = true;
            //webBrowser1.Navigate("moeni.net");
        }
    }
}
