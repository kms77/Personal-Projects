﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Atractii_turistice
{
    public partial class Alba_Carolina : Form
    {
        int PW;
        bool Hided;
        public Alba_Carolina()
        {
            InitializeComponent();
            PW = panel4.Width;
            panel4.Width = panel3.Width;
            Hided = true;
        }

        private void Panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void Label1_Click(object sender, EventArgs e)
        {
            Meniu f = new Meniu();
            f.Show();
            this.Hide();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (Hided)
            {
                this.panel4.BringToFront();
                panel4.Width = panel4.Width + 20;
                if (panel4.Width >= PW)
                {
                    timer1.Stop();
                    Hided = false;
                    this.Refresh();
                    this.panel3.BringToFront();
                }
            }
            else
            {
                this.panel4.BringToFront();
                panel4.Width = panel4.Width - 20;
                if (panel4.Width <= 0)
                {
                    timer1.Stop();
                    Hided = true;
                    this.Refresh();
                    this.panel3.BringToFront();
                }
            }
        }

        private void Alba_Carolina_Load(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {
            Alba_CarolinaImages f = new Alba_CarolinaImages();
            f.Show();
            this.Hide();
        }
    }
}
