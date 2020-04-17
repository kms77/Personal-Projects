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
    public partial class Meniu : Form
    {
        int PW1,PW2,PW3,PW4,PW5,PW6;
        bool Hided1,Hided2,Hided3,Hided4,Hided5,Hided6;
        public Meniu()
        {
            InitializeComponent();
            PW1 = panel3.Height;
            panel3.Height = panel4.Height;
            Hided1 = true;
            PW2 = panel5.Height;
            panel5.Height = panel6.Height;
            Hided2 = true;
            PW3 = panel7.Height;
            panel7.Height = panel8.Height;
            Hided3 = true;
            PW4 = panel9.Height;
            panel9.Height = panel10.Height;
            Hided4 = true;
            PW5 = panel11.Height;
            panel11.Height = panel12.Height;
            Hided5 = true;
            PW6 = panel13.Height;
            panel13.Height = panel14.Height;
            Hided6 = true;
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            Sign_in f = new Sign_in();
            f.Show();
            this.Hide();
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            if (Hided1)
                button6.Text = "CLOSE";
            else
                button6.Text = "OPEN";
            timer1.Start();
        }

        private void Button7_Click(object sender, EventArgs e)
        {

            if (Hided2)
                button7.Text = "CLOSE";
            else
                button7.Text = "OPEN";
            timer2.Start();
        }

        private void Timer2_Tick(object sender, EventArgs e)
        {
            if (Hided2)
            {
                panel5.Height = panel5.Height + 20;
                if (panel5.Height >= PW2)
                {
                    timer2.Stop();
                    Hided2 = false;
                    this.Refresh();
                }
            }
            else
            {
                panel5.Height = panel5.Height - 20;
                if (panel5.Height <= 0)
                {
                    timer2.Stop();
                    Hided2 = true;
                    this.Refresh();
                }
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Joc f = new Joc();
            f.Show();
            this.Hide();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            Casa_Poporului f = new Casa_Poporului();
            f.Show();
            this.Hide();
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            Delta f = new Delta();
            f.Show();
            this.Hide();
        }

        private void Button10_Click(object sender, EventArgs e)
        {
            Vesel f = new Vesel();
            f.Show();
            this.Hide();
        }

        private void Button12_Click(object sender, EventArgs e)
        {
            Peles f = new Peles();
            f.Show();
            this.Hide();
        }

        private void Button14_Click(object sender, EventArgs e)
        {
            Alba_Carolina f = new Alba_Carolina();
            f.Show();
            this.Hide();
        }

        private void Button16_Click(object sender, EventArgs e)
        {
            Transfagarasan f = new Transfagarasan();
            f.Show();
            this.Hide();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            Test f = new Test();
            f.Show();
            this.Hide();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Info f = new Info();
            f.Show();
            this.Hide();
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Button11_Click(object sender, EventArgs e)
        {
            if (Hided4)
                button11.Text = "CLOSE";
            else
                button11.Text = "OPEN";
            timer4.Start();
        }

        private void Timer4_Tick(object sender, EventArgs e)
        {
            if (Hided4)
            {
                panel9.Height = panel9.Height + 20;
                if (panel9.Height >= PW4)
                {
                    timer4.Stop();
                    Hided4 = false;
                    this.Refresh();
                }
            }
            else
            {
                panel9.Height = panel9.Height - 20;
                if (panel9.Height <= 0)
                {
                    timer4.Stop();
                    Hided4 = true;
                    this.Refresh();
                }
            }
        }

        private void Button13_Click(object sender, EventArgs e)
        {
            if (Hided5)
                button13.Text = "CLOSE";
            else
                button13.Text = "OPEN";
            timer5.Start();
        }

        private void Timer5_Tick(object sender, EventArgs e)
        {
            if (Hided5)
            {
                panel11.Height = panel11.Height + 20;
                if (panel11.Height >= PW5)
                {
                    timer5.Stop();
                    Hided5 = false;
                    this.Refresh();
                }
            }
            else
            {
                panel11.Height = panel11.Height - 20;
                if (panel11.Height <= 0)
                {
                    timer5.Stop();
                    Hided5 = true;
                    this.Refresh();
                }
            }
        }

        private void Button15_Click(object sender, EventArgs e)
        {
            if (Hided6)
                button15.Text = "CLOSE";
            else
                button15.Text = "OPEN";
            timer6.Start();
        }

        private void Timer6_Tick(object sender, EventArgs e)
        {
            if (Hided6)
            {
                panel13.Height = panel13.Height + 20;
                if (panel13.Height >= PW6)
                {
                    timer6.Stop();
                    Hided6 = false;
                    this.Refresh();
                }
            }
            else
            {
                panel13.Height = panel13.Height - 20;
                if (panel13.Height <= 0)
                {
                    timer6.Stop();
                    Hided6 = true;
                    this.Refresh();
                }
            }
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            if (Hided3)
                button9.Text = "CLOSE";
            else
                button9.Text = "OPEN";
            timer3.Start();
        }

        private void Timer3_Tick(object sender, EventArgs e)
        {
            if (Hided3)
            {
                panel7.Height = panel7.Height + 20;
                if (panel7.Height >= PW3)
                {
                    timer3.Stop();
                    Hided3 = false;
                    this.Refresh();
                }
            }
            else
            {
                panel7.Height = panel7.Height - 20;
                if (panel7.Height <= 0)
                {
                    timer3.Stop();
                    Hided3 = true;
                    this.Refresh();
                }
            }
        }

        private void Meniu_Load(object sender, EventArgs e)
        {

        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (Hided1)
            {
                panel3.Height = panel3.Height + 20;
                if (panel3.Height >= PW1)
                {
                    timer1.Stop();
                    Hided1 = false;
                    this.Refresh();
                }
            }
            else
            {
                panel3.Height = panel3.Height - 20;
                if (panel3.Height <= 0)
                {
                    timer1.Stop();
                    Hided1 = true;
                    this.Refresh();
                }
            }
        }

    }
}
