using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BdBoss
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void FindFilesBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)       // 파일찾기 창 띄우기 그리고 확인누르면 아래롱
            {
                WindowsMediaPlayer.URL = openFileDialog.FileName;                       // 열기를 누르면 실행됨
            }
        }
    }
}
