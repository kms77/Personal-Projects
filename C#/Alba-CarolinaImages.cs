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
    public partial class Alba_CarolinaImages : Form
    {
        public Alba_CarolinaImages()
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
            slidePic.ImageLocation = string.Format(@"AlbaCarolina\{0}.jpg", imageNumber);
            imageNumber++;
        }
        private void Label1_Click(object sender, EventArgs e)
        {
            Alba_Carolina f = new Alba_Carolina();
            f.Show();
            this.Hide();
        }
        private void ChangeImage(object sender, EventArgs e)
        {
            List<Bitmap> b1 = new List<Bitmap>();
            b1.Add(Properties.Resources.alba1);
            b1.Add(Properties.Resources.alba2);
            b1.Add(Properties.Resources.alba3);
            b1.Add(Properties.Resources.alba4);
            b1.Add(Properties.Resources.alba5);
            b1.Add(Properties.Resources.alba6);
            int index = DateTime.Now.Second % b1.Count;
            slidePic.BackgroundImage = b1[index];
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            LoadNextImage();
        }
    }
}
