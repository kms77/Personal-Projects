using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Atractii_turistice
{
    public partial class Casa_Poporului : Form
    {
        int PW;
        bool Hided;
        public Casa_Poporului()
        {
            InitializeComponent();
            PW = panel5.Width;
            panel5.Width = panel4.Width;
            Hided = true;
        }

        private void Label1_Click(object sender, EventArgs e)
        {
            Meniu f=new Meniu();
            f.Show();
            this.Hide();
        }

        private void TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TextBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (Hided)
            {
                this.panel5.BringToFront();
                panel5.Width = panel5.Width + 20;
                if (panel5.Width >= PW)
                {
                    timer1.Stop();
                    Hided = false;
                    this.Refresh();
                    this.panel4.BringToFront();
                }
            }
            else
            {
                this.panel5.BringToFront();
                panel5.Width = panel5.Width - 20;
                if (panel5.Width <= 0)
                {
                    timer1.Stop();
                    Hided = true;
                    this.Refresh();
                    this.panel4.BringToFront();
                }
            }
        }

        private void Casa_Poporului_Load(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {
            Parlament_Images f = new Parlament_Images();
            f.Show();
            this.Hide();
        }
    }
}
