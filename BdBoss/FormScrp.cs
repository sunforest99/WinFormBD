using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BdBoss
{
    class FormScrp
    {
        private static FormScrp _Instance = null;

        public static FormScrp I
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new FormScrp();
                    Console.WriteLine("instance is null");
                }
                return _Instance;
            }
        }

        private Form2 StackForm = new Form2();
        private Form3 MediaForm = new Form3();
        private Form4 WebForm = new Form4();
        public bool bEnablecheck = false;

        public void CreateStack()
        {
            StackForm = new Form2();
            StackForm.Show();
        }

        public void CreateMedia()
        {
            MediaForm = new Form3();
            MediaForm.Show();
        }

        public void CreateWeb()
        {
            WebForm = new Form4();
            WebForm.Show();
        }

        public void ButtonOff()
        {
            StackForm.Enabled = false;
            MediaForm.Enabled = false;
            WebForm.Enabled = false;
        }

        public void ButtonOn()
        {
            StackForm.Enabled = true;
            MediaForm.Enabled = true;
            WebForm.Enabled = true;
        }
    }
}
