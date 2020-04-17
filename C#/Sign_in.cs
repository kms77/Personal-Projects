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
    public partial class Sign_in : Form
    {
        public Sign_in()
        {
            InitializeComponent();
        }
        private int imageNumber = 1;
        private void LoadNextImage()
        {
            if(imageNumber==11)
            {
                imageNumber = 1;
            }
            slidePic.ImageLocation = string.Format(@"Images\{0}.jpg", imageNumber);
            imageNumber++;
        }
        private void Timer1_Tick(object sender, EventArgs e)
        {
            LoadNextImage();
        }
        private void Button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "user" && textBox2.Text == "parola")
            {
                Meniu f = new Meniu();
                f.Show();
                this.Hide();
            }
            else
                MessageBox.Show("Username sau parolă greșită !", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            textBox1.Text = "";
            textBox2.Text = "";
        }
        private void Button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Username: user" + "\n" + "Password: parola", "Info", MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void SlidePic_Click(object sender, EventArgs e)
        {

        }
    }
}
