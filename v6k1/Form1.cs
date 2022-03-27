using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace v6k1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int x = 5;
        public void Button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            timer2.Enabled = false;

           
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            
            
        }

        int pc;
        public void Timer1_Tick(object sender, EventArgs e)
        {
            pc=piccar.Left += x;
        }

        private void Label1_Click(object sender, EventArgs e)
        {
            if (piccar.Bounds.IntersectsWith(label1.Bounds))
            {
                timer1.Enabled = false;
            }
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            x++;
        }

        private void Piccar_Click(object sender, EventArgs e)
        {
            
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            timer2.Enabled = true;

        }

        private void Timer2_Tick(object sender, EventArgs e)
        {
            pc = piccar.Left -= x;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

       
    }
}
