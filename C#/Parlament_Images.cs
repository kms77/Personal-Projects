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
    public partial class Parlament_Images : Form
    {
        public Parlament_Images()
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
            slidePic.ImageLocation = string.Format(@"Parlament\{0}.jpg", imageNumber);
            imageNumber++;
        }
        private void Label1_Click(object sender, EventArgs e)
        {
            Casa_Poporului f = new Casa_Poporului();
            f.Show();
            this.Hide();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            LoadNextImage();
        }
    }
}
