using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FacebookApp
{
    using System.Security.Cryptography.X509Certificates;

    public partial class GridPictureBoxesWithTitle : UserControl
    {
        private const int k_GridPictureBoxHeight = 75;

        private const int k_GridPictureBoxWidth = 75;

        private const int k_Margin = 10;

        private PictureBox[,] m_GridPictureBoxs;

        public string TitleText
        {
            set
            {
                labelTitle.Text = value;
            }
        }

        public int GridRows { get; set; }

        public int GridColumns { get; set; }

        public Image TitleIamge
        {
            set
            {
                pictureBoxTitle.Image = value;
            }
        }

        public GridPictureBoxesWithTitle()
        {
            InitializeComponent();
        }

        public void Init(List<Image> i_Images)
        {
            if (i_Images != null)
            {
                m_GridPictureBoxs = new PictureBox[GridRows, GridColumns];
                for (int i = 0; i < GridRows; i++)
                {
                    for (int j = 0; j < GridColumns; j++)
                    {
                        if (i_Images.Count > (i + j))
                        {
                            m_GridPictureBoxs[i, j] = new PictureBox();
                            m_GridPictureBoxs[i, j].Image = i_Images[i + j];
                            m_GridPictureBoxs[i, j].Size = new Size(k_GridPictureBoxWidth, k_GridPictureBoxHeight);
                            m_GridPictureBoxs[i, j].Left = pictureBoxTitle.Left + j *(k_Margin + k_GridPictureBoxWidth);
                            m_GridPictureBoxs[i, j].Top = pictureBoxTitle.Top + pictureBoxTitle.Height + i*(k_Margin + k_GridPictureBoxHeight)
                                                          + i * (k_Margin + 1);
                            Controls.Add(m_GridPictureBoxs[i, j]);
                        }
                    }
                }
            }
        }
    }
}