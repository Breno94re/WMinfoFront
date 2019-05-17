using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WMinfo_Front
{
    public partial class Home : UserControl
    {
        public Home()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            if(CPUTV.Height == 23)
            {
                CPUTV.Scrollable = true;
                CPUTV.Height = 463;
                CPUTV.ExpandAll();
            }
            else
            {
                CPUTV.Scrollable = false;
                CPUTV.Height = 23;
                CPUTV.CollapseAll();
                
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (GPUTV.Height == 23)
            {
                GPUTV.Scrollable = true;
                GPUTV.Height = 463;
                GPUTV.ExpandAll();
            }
            else
            {
                GPUTV.Scrollable = false;
                GPUTV.Height = 23;
                CPUTV.CollapseAll();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (HDDTV.Height == 23)
            {
                HDDTV.Scrollable = true;
                HDDTV.Height = 463;
                HDDTV.ExpandAll();
            }
            else
            {
                HDDTV.Scrollable = false;
                HDDTV.Height = 23;
                HDDTV.CollapseAll();
            }
        }

        private void HDDTV_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void GPUTV_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (RAMTV.Height == 23)
            {
                RAMTV.Scrollable = true;
                RAMTV.Height = 463;
                RAMTV.ExpandAll();
            }
            else
            {
                RAMTV.Scrollable = false;
                RAMTV.Height = 23;
                RAMTV.CollapseAll();
            }
        }
        public static bool open = false;
        public static bool openform = false;

        public static ConsolePC1 pcform;

        private void button10_Click(object sender, EventArgs e)
        {
            open = true;

            if (openform == false)
            {
                openform = true;
                if (pcform == null)
                {
                    pcform = new ConsolePC1();   //Create form if not created
                }

                pcform.Show(this);  //Show Form assigning this form as the forms owner
            }
        }

        private void hname1_Click(object sender, EventArgs e)
        {
           
        }

        public static bool open1 = false;
        public static bool openform1 = false;

        public static TaskManagerPC1 pcform1;

        private void button11_Click(object sender, EventArgs e)
        {
            open1 = true;

            if (openform1 == false)
            {
                openform1 = true;
                if (pcform1 == null)
                {
                    pcform1 = new TaskManagerPC1();   //Create form if not created
                }

                pcform1.Show(this);  //Show Form assigning this form as the forms owner
            }
        }

        public static bool open2 = false;
        public static bool openform2 = false;

        public static RemoteScreencs pcform2;

        private void button12_Click(object sender, EventArgs e)
        {
            ListenerPC1.SetResponse("remotepc*low");

            open2 = true;

            if (openform2 == false && openform1 == false)
            {
                openform2 = true;
                if (pcform2 == null)
                {
                    pcform2 = new RemoteScreencs();   //Create form if not created
                }

                pcform2.Show(this);  //Show Form assigning this form as the forms owner
            }
        }
    }
}
