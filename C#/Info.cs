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
    public partial class Info : Form
    {
        public Info()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Meniu f = new Meniu();
            f.Show();
            this.Hide();
        }
    }
}
