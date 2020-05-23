using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace timer
{
    public partial class Sekond : Form
    {
        public Sekond()
        {
            InitializeComponent();
        }
        int tik_mm;
        int tik_hh;
        int tik_ss;
        string timer_ss;
        string timer_mm;
        string timer_hh;
        private void timer_log_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer.Enabled = !timer.Enabled;
        }
        

        private void timer_Tick_1(object sender, EventArgs e)
        {
            if (tik_ss >= 60)
            {
                tik_ss = 0;
                tik_mm++;
                timer_ss = tik_ss.ToString();
            }
            if (tik_ss <= 9)
            {
                timer_ss = "0" + tik_ss.ToString();
            }
            else
            {
                timer_ss = tik_ss.ToString();
            }

            if (tik_mm >= 60)
            {
                tik_mm = 0;
                tik_hh++;
                timer_mm = tik_mm.ToString();
            }
            if (tik_mm <= 9)
            {
                timer_mm = "0" + tik_mm.ToString();
            }
            else
            {
                timer_mm = tik_mm.ToString();
            }

            if (tik_hh >= 168)
            {
                tik_hh = 0;

                timer_hh = tik_hh.ToString();
            }
            if (tik_hh <= 9)
            {
                timer_hh = "0" + tik_hh.ToString();
            }
            else
            {
                timer_hh = tik_hh.ToString();
            }

            timer_log.Text = timer_hh + ":" + timer_mm + ":" + timer_ss;
            tik_ss++;
        }

        
    }
}
