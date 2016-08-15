﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FacebookApp
{
    public partial class InfoItem : UserControl
    {
        public InfoItem()
        {
            InitializeComponent();
            
        }

        public string InfoText
        {
            set
            {
                labelInfo.Text = value;
            }
        }

        public Image InfoImage
        {
            set
            {
                pictureBoxInfo.Image = value;
            }
        }
    }
}
