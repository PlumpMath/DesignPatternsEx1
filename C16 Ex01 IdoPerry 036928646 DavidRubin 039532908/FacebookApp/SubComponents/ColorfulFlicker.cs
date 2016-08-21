using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace FacebookApp.SubComponents
{
    public partial class ColorfulFlicker : UserControl
    {
        private readonly List<Color> r_ColorsList = new List<Color>()
                                                        {
                                                            Color.Black,
                                                            Color.Chartreuse,
                                                            Color.Crimson,
                                                            Color.CornflowerBlue
                                                        };

        private bool m_IsOn = false;
        private int m_FlickerSpeed = 200;
        private Timer m_FlickerTimer;

        public delegate void FlickerHandler(ColorfulFlicker i_Flicker, bool i_IsOn);

        public event FlickerHandler OnFlickerChange;

        public bool On
        {
            get
            {
                return m_IsOn;
            }

            set
            {
                m_IsOn = value;
                UpdateView();
            }
        }

        private void UpdateView()
        {
            Visible = m_IsOn;
            if (m_IsOn)
            {
                int colorIndex = new Random().Next(0, r_ColorsList.Count);
                BackColor = r_ColorsList[colorIndex];
            }
        }

        public ColorfulFlicker()
        {
            InitializeComponent();
            m_FlickerTimer = new Timer();
            m_FlickerTimer.Interval = m_FlickerSpeed;
            m_FlickerTimer.Tick += FlickerTimerOnTick;
        }

        private void FlickerTimerOnTick(object i_Sender, EventArgs i_E)
        {
            On = !On;
            if (OnFlickerChange != null)
            {
                OnFlickerChange.Invoke(this, On);
            }
        }

        public void StartFlickering()
        {
            m_FlickerTimer.Start();
        }
    }
}
