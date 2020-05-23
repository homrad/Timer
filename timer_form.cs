using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace timer
{
    public partial class timer_form : Form
    {
        public timer_form()
        {
            InitializeComponent();
        }

        private void timer_log_Click(object sender, EventArgs e)
        {

        }
        int tik_ss;
        int tik_mm;
        int tik_hh;
        string timer_ss;
        string timer_mm;
        string timer_hh;
        string t;

        private void button1_Click(object sender, EventArgs e)
        {
            timermin.Enabled = !timermin.Enabled;
            button2.Enabled = !button2.Enabled;
            HH.Enabled = !HH.Enabled;
            MM.Enabled = !MM.Enabled;
            SS.Enabled = !SS.Enabled;





        }
        

        

        private void timermin_Tick(object sender, EventArgs e)
        {
            if (tik_ss <0)
            {
                SoundPlayer Simple = new SoundPlayer(@"C:\Windows\Media\Alarm01.wav");
                Simple.Play();
                timermin.Stop();
                timer_log.Text =  "00:00:00" ; 
                MessageBox.Show("время вышло");
                
                    
            }
            else
            {
                if (tik_ss <= 0 && (tik_mm != 0 || tik_hh != 0))
                {
                    tik_ss = 60;
                    tik_mm--;
                }
                if (tik_ss <= 9 && tik_ss >= 0)
                {
                    timer_ss = "0" + tik_ss.ToString();
                }
                else
                {
                    timer_ss = tik_ss.ToString();
                }

                if (tik_mm <= 0 && tik_hh != 0)
                {
                    tik_mm = 60;
                    tik_hh--;
                }
                if (tik_mm <= 9 && tik_mm >= 0)
                {
                    timer_mm = "0" + tik_mm.ToString();
                }
                else
                {
                    timer_mm = tik_mm.ToString();
                }

                if (tik_hh <= 0)
                {
                    tik_hh = 0;

                }
                if (tik_hh <= 9 && tik_hh >= 0)
                {
                    timer_hh = "0" + tik_hh.ToString();
                }
                else
                {
                    timer_hh = tik_hh.ToString();
                }
            }



            timer_log.Text = timer_hh + ":" + timer_mm + ":" + timer_ss;
            tik_ss--;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button1.Enabled = !button1.Enabled; 
            tik_ss = Convert.ToInt32(SS.Text);
            tik_mm = Convert.ToInt32(MM.Text);
            tik_hh = Convert.ToInt32(HH.Text);

            if ((tik_hh > 24) && (tik_mm > 60) && (tik_ss > 60))
            {
                MessageBox.Show("вы там как? со временем то дружите?");
                tik_hh = 24;
                tik_mm = 60;
                tik_ss = 60;
                HH.Text = 24.ToString();
                MM.Text = 60.ToString();
                SS.Text = 60.ToString();
            }
            else
            {
                if (tik_hh > 24)
                {
                    MessageBox.Show("в сутакх 24 часа");
                    tik_hh = 24;
                    HH.Text = 24.ToString();
                }
                if (tik_mm > 60)
                {
                    MessageBox.Show("в часе 60 минут");
                    tik_mm = 60;
                    MM.Text = 60.ToString();
                }
                if (tik_ss > 60)
                {
                    MessageBox.Show("в минуте 60 секунд");
                    tik_ss = 60;
                    SS.Text = 60.ToString();
                }
            }

                        
            timer_log.Text =tik_hh + ":" + tik_mm + ":" + tik_ss;
        }

        private void HH_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {
                return;
            }
            e.Handled = true;
        }

        private void MM_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {
                return;
            }
            e.Handled = true;
        }

        private void SS_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {
                return;
            }
            e.Handled = true;
        }

        private void timer_form_Load(object sender, EventArgs e)
        {
            button1.Enabled = false;
        }
    }
}
