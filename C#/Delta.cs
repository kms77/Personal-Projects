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
    public partial class Delta : Form
    {
        int PW;
        bool Hided;
        public Delta()
        {
            InitializeComponent();
            PW = panel3.Width;
            panel3.Width = panel4.Width;
            Hided = true;
        }

        private void Delta_Load(object sender, EventArgs e)
        {

        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
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
                this.panel3.BringToFront();
                panel3.Width = panel3.Width + 20;
                if (panel3.Width >= PW)
                {
                    timer1.Stop();
                    Hided = false;
                    this.Refresh();
                    this.panel4.BringToFront();
                }
            }
            else
            {
                this.panel3.BringToFront();
                panel3.Width = panel3.Width - 20;
                if (panel3.Width <= 0)
                {
                    timer1.Stop();
                    Hided = true;
                    this.Refresh();
                    this.panel4.BringToFront();
                }
            }
        }

        private void Label1_Click(object sender, EventArgs e)
        {
            Meniu f = new Meniu();
            f.Show();
            this.Hide();
        }

        private void Label2_Click(object sender, EventArgs e)
        {
            Delta_Images f= new Delta_Images();
            f.Show();
            this.Hide();
        }
    }
}
