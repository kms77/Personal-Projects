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
    public partial class Transfagarasa_Images : Form
    {
        public Transfagarasa_Images()
        {
            InitializeComponent();
        }
        private int imageNumber = 1;
        private void LoadNextImage()
        {
            if (imageNumber == 7)
            {
                imageNumber = 1;
            }
            slidePic.ImageLocation = string.Format(@"Transfagarasan\{0}.jpg", imageNumber);
            imageNumber++;
        }
        private void Label1_Click(object sender, EventArgs e)
        {
            Transfagarasan f = new Transfagarasan();
            f.Show();
            this.Hide();
        }

        private void Transfagarasa_Images_Load(object sender, EventArgs e)
        {

        }
        
        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            LoadNextImage();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
