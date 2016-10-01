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
    using FacebookApp.GridItemFactory;

    public partial class GridPictureBoxesWithTitle : UserControl
    {
        private const int startingIndex = 0;

        private const int k_Margin = 10;

        private PictureBox[,] m_GridPictureBoxs;

        private GridItems m_GridItems;

        public event EventHandler GridItemClick;

        private void gridItem_Click(object sender, EventArgs e)
        {
            PictureBox clickedPictureBox = sender as PictureBox;
            if (clickedPictureBox != null)
            {
                int selectGridItemIndex = int.Parse(clickedPictureBox.Text);
                if (GridItemClick != null)
                {
                    GridItemClick.Invoke(m_GridItems[selectGridItemIndex], e);
                }
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

        public int GridItemHeight { get; set; }

        public int GridItemWidth { get; set; }

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

        public void Init(GridItems i_GridItems)
        {
            m_GridItems = i_GridItems;
            m_GridItems.Strategy = new GridItems.RetrivalStrategy(startingIndex, GridColumns + GridRows);

            if (i_GridItems != null)
            {
                reset();
                m_GridPictureBoxs = new PictureBox[GridRows, GridColumns];
                int i = 0, j = 0;
                int counter = 0;
                foreach (IGridItem gridItem in m_GridItems)
                {
                    m_GridPictureBoxs[i, j] = new PictureBox();
                    m_GridPictureBoxs[i, j].Text = counter.ToString();
                    ++counter;
                    m_GridPictureBoxs[i, j].Click += gridItem_Click;
                    m_GridPictureBoxs[i, j].BackgroundImageLayout = ImageLayout.Center;
                    m_GridPictureBoxs[i, j].BackgroundImage = gridItem.ImageThumb;
                    m_GridPictureBoxs[i, j].Size = new Size(GridItemWidth, GridItemHeight);
                    m_GridPictureBoxs[i, j].Left = pictureBoxTitle.Left + (j * (k_Margin + GridItemWidth));
                    m_GridPictureBoxs[i, j].Top = pictureBoxTitle.Top + pictureBoxTitle.Height
                                                  + (i * (k_Margin + GridItemHeight)) + k_Margin;
                    Controls.Add(m_GridPictureBoxs[i, j]);
                    ++j;
                    if (j == GridColumns)
                    {
                        j = 0;
                        ++i;
                    }
                }
            }
        }

        private void reset()
        {
            if (m_GridPictureBoxs != null)
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
}