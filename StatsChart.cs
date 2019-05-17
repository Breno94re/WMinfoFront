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
    public partial class StatsChart : UserControl
    {
        public StatsChart()
        {
            InitializeComponent();
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(panel4.Visible == false)
            {
                panel4.Visible = true;
            }
            else
            {
                panel4.Visible = false;
            }
        }

        private void monthCalendar2_DateChanged(object sender, DateRangeEventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox1.SelectedItem.ToString().ToLower() == "temperature")
            {
                cputext.Text = "CPU - Temperatures";
            }

            if (comboBox1.SelectedItem.ToString().ToLower() == "load")
            {
                cputext.Text = "CPU - Load";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
