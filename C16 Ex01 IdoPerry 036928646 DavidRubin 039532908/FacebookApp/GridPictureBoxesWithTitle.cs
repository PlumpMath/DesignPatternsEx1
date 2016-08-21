using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using FacebookApp.Interfaces;

namespace FacebookApp
{
    public partial class GridPictureBoxesWithTitle : UserControl
    {
        private const int k_GridPictureBoxHeight = 75;

        private const int k_GridPictureBoxWidth = 75;

        private const int k_Margin = 10;

        private PictureBox[,] m_GridPictureBoxs;

        private List<IGridItem> m_CurrentGridItems;

        public event EventHandler GridItemClick;

        private void gridItem_Click(object sender, EventArgs e)
        {
            PictureBox clickedPictureBox = sender as PictureBox;
            if (clickedPictureBox != null)
            {
                int selectGridItemIndex = int.Parse(clickedPictureBox.Text);
//                GridItemClick?.Invoke(m_CurrentGridItems[selectGridItemIndex], e);
            }

            
        }

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

        public void Init(List<IGridItem> i_GridItems)
        {
            m_CurrentGridItems = i_GridItems;
            if (i_GridItems != null)
            {
                m_GridPictureBoxs = new PictureBox[GridRows, GridColumns];
                int counter = 0;
                for (int i = 0; i < GridRows; i++)
                {
                    for (int j = 0; j < GridColumns; j++)
                    {
                        if (i_GridItems.Count > counter)
                        {
                            m_GridPictureBoxs[i, j] = new PictureBox();
                            m_GridPictureBoxs[i, j].Text = counter.ToString();
                            m_GridPictureBoxs[i, j].Click += gridItem_Click;
                            m_GridPictureBoxs[i, j].BackgroundImageLayout = ImageLayout.Center;
                            m_GridPictureBoxs[i, j].BackgroundImage = i_GridItems[counter].GetImage();
                            ++counter;
                            m_GridPictureBoxs[i, j].Size = new Size(k_GridPictureBoxWidth, k_GridPictureBoxHeight);
                            m_GridPictureBoxs[i, j].Left = pictureBoxTitle.Left + j * (k_Margin + k_GridPictureBoxWidth);
                            m_GridPictureBoxs[i, j].Top = pictureBoxTitle.Top + pictureBoxTitle.Height
                                                          + i * (k_Margin + k_GridPictureBoxHeight) + k_Margin;
                            Controls.Add(m_GridPictureBoxs[i, j]);
                        }
                    }
                }
            }
        }

        public void Reset()
        {
            for (int i = 0; i < GridRows; i++)
            {
                for (int j = 0; j < GridColumns; j++)
                {
                    if (m_GridPictureBoxs[i, j] != null)
                    {
                        Controls.Remove(m_GridPictureBoxs[i, j]);
                        m_GridPictureBoxs[i, j].Dispose();
                    }
                }
            }
        }
    }
}