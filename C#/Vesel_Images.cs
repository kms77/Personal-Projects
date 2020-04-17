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
    public partial class Vesel_Images : Form
    {
        public Vesel_Images()
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
            slidePic.ImageLocation = string.Format(@"Vesel\{0}.jpg", imageNumber);
            imageNumber++;
        }
        private void Vesel_Images_Load(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {
            Vesel f = new Vesel();
            f.Show();
            this.Hide();
        }
       

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            LoadNextImage();
        }
    }
}
