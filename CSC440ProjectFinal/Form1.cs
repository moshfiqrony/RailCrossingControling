using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSC440ProjectFinal
{
    public partial class Form1 : Form
    {
        Timer Clock = new Timer();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Clock.Interval = 1000;
            Clock.Tick += new EventHandler(this.Clock_Tcik);
            Clock.Start();

        }

        private void Clock_Tcik(object sender, EventArgs e)
        {
            int hh = DateTime.Now.Hour;
            int mm = DateTime.Now.Minute;
            int ss = DateTime.Now.Second;
            string time="";
            if(hh < 10)
            {
                time += "0" + hh;
            }
            else
            {
                time += hh;
            }
            time += ":";
            if (mm < 10)
            {
                time += "0" + mm;
            }
            else
            {
                time += mm;
            }
            time += ":";
            if (ss < 10)
            {
                time += "0" + ss;
            }
            else
            {
                time += ss;
            }
            ClockLabel.Text = time;
        }

        private void Train1_Click(object sender, EventArgs e)
        {

        }

        private void Map_Click(object sender, EventArgs e)
        {
            Form2 MapForm = new Form2();
            MapForm.Show();

        }
    }
}
