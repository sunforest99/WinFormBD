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
            Encoding encode = System.Text.Encoding.GetEncoding("ks_c_5601-1987");
            StreamReader sr = new StreamReader("Stack.txt", encode);
            String line;
            while ((line = sr.ReadLine()) != null)
            {
                listBox1.Items.Add(line);
            }
        }
    }
}
