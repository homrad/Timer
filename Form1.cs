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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           

        }
                 

        private void секудомерToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sekond sekond = new Sekond();
            sekond.MdiParent = this;
            sekond.Show();
        }

        private void таймерToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer_form timer = new timer_form();
            timer.MdiParent = this;
            timer.Show();
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            doc doc = new doc();
            doc.MdiParent = this;
            doc.Show();
        }
        string lab1;
        string lab2;
        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString("HH:mm:ss");
            lab1 = label1.Text;
            lab2 = label2.Text + ":00";
            if (lab1 == lab2)
            {
                SoundPlayer Simple = new SoundPlayer(@"C:\Windows\Media\Alarm01.wav");
                Simple.Play();
                MessageBox.Show("Время вышло");
            }
          

        }

        

        
        int hh;
        int mm;
        string hh_str;
        string mm_str;

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            mm = Convert.ToInt32(comboBox2.Text);

            hh = Convert.ToInt32(comboBox1.Text);

            if (hh <= 9)
            {
                hh_str = "0" + hh;
            }
            else
            {
                hh_str = hh.ToString();
            }
            if (mm <= 9)
            {
                mm_str = "0" + mm;
            }
            else
            {
                mm_str = mm.ToString();
            }

            label2.Text = hh_str + ":" + mm_str;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
