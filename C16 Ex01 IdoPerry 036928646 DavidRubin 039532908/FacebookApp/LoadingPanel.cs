using System.Windows.Forms;
using System;
using System.Diagnostics;
using System.Drawing;
using Timer = System.Timers.Timer;

namespace FacebookApp
{


    public partial class LoadingPanel : UserControl
    {
        private int m_AnimationSpeed = 12;
        private int m_CurrentSquareMarked = 0;
        private const int k_SquareCount = 10;
        private string m_loadingName = "";

        public string LoadingLabel
        {
            get
            {
                return m_loadingName;
            }
            set
            {
                m_loadingName = value;
                labelLoadingName.Text = "Loading " + m_loadingName + "...";
            }
        }

        public int CurrentActiveSquare
        {
            get
            {
                return m_CurrentSquareMarked;
            }
            set
            {
                m_CurrentSquareMarked = value;
                if (value >= k_SquareCount)
                {
                    m_CurrentSquareMarked = 0;
                }
                MarkSquareIndexed(m_CurrentSquareMarked);
            }
        }

        private void MarkSquareIndexed(int i_squareToMarkIndex)
        {
            //special name
            string nameToMark = "labelSquare" + (i_squareToMarkIndex + 1).ToString();

            for (int i = 0; i < k_SquareCount; i++)
            {
                Controls[i].BackColor = Color.Transparent;
                
            }

            Controls.Find(nameToMark, true)[0].BackColor = Color.Black;
        }

        public int AnimationSpeed
        {
            get
            {
                return m_AnimationSpeed;
            }
            set
            {
                m_AnimationSpeed = value;
            }
        }

        public LoadingPanel()
        {
            InitializeComponent();
            Start();
        }

        public void Start()
        {
            Timer timer = new Timer(1000/m_AnimationSpeed);
            timer.Elapsed += TimerOnTick;
            timer.Start();
        }

        private void TimerOnTick(object sender, EventArgs eventArgs)
        {
            CurrentActiveSquare++;
        }
    }
}
