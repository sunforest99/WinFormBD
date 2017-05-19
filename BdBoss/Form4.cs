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
            webBrowser1.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(textBox1.Text);
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            System.Windows.Forms.HtmlDocument document = this.webBrowser1.Document;
            //InternetExplorer ex = new InternetExplorer();
            //ex.Visible = true;
            //ex.Navigate("ani.today");
            this.TopMost = true;
            //webBrowser1.Navigate("moeni.net");
        }
    }
}
