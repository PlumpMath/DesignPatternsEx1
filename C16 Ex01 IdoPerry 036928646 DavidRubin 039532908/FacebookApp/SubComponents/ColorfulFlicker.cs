using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FacebookApp.SubComponents
{
    public partial class ColorfulFlicker : UserControl
    {
        private bool m_isOn = false;
        private int m_flickerSpeed = 200;
        private Timer m_flickerTimer;
        private readonly List<Color> r_colorsList = new List<Color>() { Color.Black, Color.Chartreuse, Color.Crimson, Color.CornflowerBlue };

        public delegate void FlickerHandler(ColorfulFlicker flicker,bool i_IsOn);

        public event FlickerHandler OnFlickerChange;

        public bool On
        {
            get
            {
                return m_isOn;
            }
            set
            {
                m_isOn = value;
                UpdateView();
            }
        }

        private void UpdateView()
        {
            Visible = m_isOn;
            if (m_isOn)
            {
                int colorIndex = new Random().Next(0, r_colorsList.Count);
                BackColor = r_colorsList[colorIndex];
            }
        }

        public ColorfulFlicker()
        {
            InitializeComponent();
            m_flickerTimer = new Timer();
            m_flickerTimer.Interval = m_flickerSpeed;
            m_flickerTimer.Tick += FlickerTimerOnTick;
        }

        private void FlickerTimerOnTick(object sender, EventArgs eventArgs)
        {
            On = !On;
            if (OnFlickerChange != null)
            {
                OnFlickerChange.Invoke(this,On);
            }
        }

        public void StartFlickering()
        {
            m_flickerTimer.Start();
        }
    }
}
