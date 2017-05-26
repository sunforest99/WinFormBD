using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BdBoss
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Encoding encode = System.Text.Encoding.GetEncoding("ks_c_5601-1987");       // 한글깨짐으로 인코딩 해주기
            StreamReader sr = new StreamReader(@"./Stack.txt", encode);
            String sline;
            while ((sline = sr.ReadLine()) != null)      // 파일이 끝날때까징
            {
                StackList.Items.Add(sline);              // 계속 추가아아아아ㅏ아
            }
        }
    }
}
