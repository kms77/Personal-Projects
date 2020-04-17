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
    public partial class Test : Form
    {
        public Test()
        {
            InitializeComponent();
        }
        private void AskPermission()
        {
            DialogResult dialog = MessageBox.Show("Vrei să ieși ?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                Meniu f = new Meniu();
                f.Show();
                this.Hide();
            }
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            AskPermission();
        }
        private void AskPermission1()
        {
            DialogResult dialog = MessageBox.Show("Reîncerci testul ?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                button3.Visible = true;
                checkBox1.Checked = false;
                checkBox2.Checked = false;
                checkBox3.Checked = false;
                checkBox4.Checked = false;
                checkBox5.Checked = false;
                checkBox6.Checked = false;
                checkBox7.Checked = false;
                checkBox8.Checked = false;
                checkBox9.Checked = false;
                checkBox10.Checked = false;
                checkBox11.Checked = false;
                checkBox12.Checked = false;
                checkBox13.Checked = false;
                checkBox14.Checked = false;
                checkBox15.Checked = false;
                checkBox16.Checked = false;
                checkBox17.Checked = false;
                checkBox18.Checked = false;
                checkBox19.Checked = false;
                checkBox20.Checked = false; 
                checkBox21.Checked = false;
                checkBox22.Checked = false;
                checkBox23.Checked = false;
                checkBox24.Checked = false;
                checkBox25.Checked = false;
                checkBox26.Checked = false;
                checkBox27.Checked = false;
                label1.ForeColor = Color.Black;
                label1.Text = ".";
                label2.ForeColor = Color.Black;
                label2.Text = ".";
                label3.ForeColor = Color.Black;
                label3.Text = ".";
                label4.ForeColor = Color.Black;
                label4.Text = ".";
                label5.ForeColor = Color.Black;
                label5.Text = ".";
                label6.ForeColor = Color.Black;
                label6.Text = ".";
                label7.ForeColor = Color.Black;
                label7.Text = ".";
                label8.ForeColor = Color.Black;
                label8.Text = ".";
                label9.ForeColor = Color.Black;
                label9.Text = ".";
            }
        }
        private void Button2_Click(object sender, EventArgs e)
        {
            AskPermission1();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            int g1=0,g2=0,g3=0,g4=0,g5=0,g6=0,g7=0,g8=0,g9=0, ct = 1;
            if (checkBox1.Checked == true || checkBox2.Checked == true || checkBox3.Checked == true)
            {
                g1 = 1;
                if (checkBox1.Checked == false && checkBox2.Checked == true && checkBox3.Checked == false)
                {
                    ct++;
                    label1.Text = "V";
                    label1.ForeColor = Color.Blue;
                }
                else
                {
                    label1.ForeColor = Color.Red;
                    label1.Text = "X";
                }
            }
            if (checkBox4.Checked == true || checkBox5.Checked == true || checkBox6.Checked == true)
            {
                g2 = 1;
                if (checkBox4.Checked == false && checkBox5.Checked == false && checkBox6.Checked == true)
                {
                    ct++;
                    label2.Text = "V";
                    label2.ForeColor = Color.Blue;
                }
                else
                {
                    label2.ForeColor = Color.Red;
                    label2.Text = "X";
                }
            }
            if (checkBox7.Checked == true || checkBox8.Checked == true || checkBox9.Checked == true)
            {
                g3 = 1;
                if (checkBox7.Checked == false && checkBox8.Checked == true && checkBox9.Checked == false)
                {
                    ct++;
                    label3.Text = "V";
                    label3.ForeColor = Color.Blue;
                }
                else
                {
                    label3.ForeColor = Color.Red;
                    label3.Text = "X";
                }
            }
            if (checkBox10.Checked == true || checkBox11.Checked == true || checkBox12.Checked == true)
            {
                g4 = 1;
                if (checkBox10.Checked == true && checkBox11.Checked == false && checkBox12.Checked == false)
                {
                    ct++;
                    label4.Text = "V";
                    label4.ForeColor = Color.Blue;
                }
                else
                {
                    label4.ForeColor = Color.Red;
                    label4.Text = "X";
                }
            }
            if (checkBox13.Checked == true || checkBox14.Checked == true || checkBox15.Checked == true)
            {
                g5 = 1;
                if (checkBox13.Checked == true && checkBox14.Checked == false && checkBox15.Checked == false)
                {
                    ct++;
                    label5.Text = "V";
                    label5.ForeColor = Color.Blue;
                }
                else
                {
                    label5.ForeColor = Color.Red;
                    label5.Text = "X";
                }
            }
            if (checkBox16.Checked == true || checkBox17.Checked == true || checkBox18.Checked == true)
            {
                g6 = 1;
                if (checkBox16.Checked == false && checkBox17.Checked == true && checkBox18.Checked == false)
                {
                    ct++;
                    label6.Text = "V";
                    label6.ForeColor = Color.Blue;
                }
                else
                {
                    label6.ForeColor = Color.Red;
                    label6.Text = "X";
                }
            }
            if (checkBox19.Checked == true || checkBox20.Checked == true || checkBox21.Checked == true)
            {
                g7 = 1;
                if (checkBox19.Checked == false && checkBox20.Checked == false && checkBox21.Checked == true)
                {
                    ct++;
                    label7.Text = "V";
                    label7.ForeColor = Color.Blue;
                }
                else
                {
                    label7.ForeColor = Color.Red;
                    label7.Text = "X";
                }
            }
            if (checkBox22.Checked == true || checkBox23.Checked == true || checkBox24.Checked == true)
            {
                g8 = 1;
                if (checkBox22.Checked == false && checkBox23.Checked == true && checkBox24.Checked == false)
                {
                    ct++;
                    label8.Text = "V";
                    label8.ForeColor = Color.Blue;
                }
                else
                {
                    label8.ForeColor = Color.Red;
                    label8.Text = "X";
                }
            }
            if (checkBox25.Checked == true || checkBox26.Checked == true || checkBox27.Checked == true)
            {
                g9 = 1;
                if (checkBox25.Checked == true && checkBox26.Checked == false && checkBox27.Checked == false)
                {
                    ct++;
                    label9.Text = "V";
                    label9.ForeColor = Color.Blue;
                }
                else
                {
                    label9.ForeColor = Color.Red;
                    label9.Text = "X";
                }
            }
            if(g1==0||g2==0||g3==0||g4==0||g5==0||g6==0||g7==0||g8==0||g9==0)
            {
                label1.ForeColor = Color.Black;
                label1.Text = ".";
                label2.ForeColor = Color.Black;
                label2.Text = ".";
                label3.ForeColor = Color.Black;
                label3.Text = ".";
                label4.ForeColor = Color.Black;
                label4.Text = ".";
                label5.ForeColor = Color.Black;
                label5.Text = ".";
                label6.ForeColor = Color.Black;
                label6.Text = ".";
                label7.ForeColor = Color.Black;
                label7.Text = ".";
                label8.ForeColor = Color.Black;
                label8.Text = ".";
                label9.ForeColor = Color.Black;
                label9.Text = ".";
                MessageBox.Show("Nu ai raspuns la toate întrebarile !", "Eroare", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Test terminat" + "\n" + "Ai luat nota: " + ct, "Felicitări",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        private void Test_Load(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}