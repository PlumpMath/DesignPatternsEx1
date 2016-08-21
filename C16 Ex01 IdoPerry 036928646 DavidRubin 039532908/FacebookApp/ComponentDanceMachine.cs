namespace FacebookApp
{
    using System;
    using System.Diagnostics;
    using System.Drawing;
    using System.Windows.Forms;

    public class ComponentDanceMachine
    {
        private const int k_TotalPartyTime = 16000;

        private const int k_ActionDuration = 20;

        private Control m_control;

        private Timer m_stopTimer;

        private Timer m_actionTimer;

        private DockStyle m_lastDock;

        private Point m_lastLocation;

        private AnchorStyles m_lasAnchorStyles;

        private int m_phase = 0;

        private int m_phaseDirection = 1;

        private int m_phaseAmp = 20;

        public static event EventHandler PartiesOver;

        public ComponentDanceMachine(Control i_control)
        {
            m_control = i_control;
        }

        /// <summary>
        /// Party for 10 seconds
        /// </summary>
        public void Start()
        {
            Random rand = new Random();
            m_phaseAmp = rand.Next(2, 20); // between 5- 20
            m_phaseDirection = (rand.Next(100) > 50) ? 1 : -1; // clockwise or counter clockwise

            m_lastDock = m_control.Dock;
            m_lastLocation = m_control.Location;
            m_lasAnchorStyles = m_control.Anchor;
            m_control.Dock = DockStyle.None;
            m_control.Anchor = AnchorStyles.None;

            m_stopTimer = new Timer();
            m_stopTimer.Interval = k_TotalPartyTime;
            m_stopTimer.Tick += StopTimerTick;
            m_actionTimer = new Timer();
            m_actionTimer.Interval = k_ActionDuration;
            m_actionTimer.Tick += ActionTimerOnTick;

            m_actionTimer.Start();
            m_stopTimer.Start();
        }

        private void ActionTimerOnTick(object sender, EventArgs eventArgs)
        {
            m_phase++;
            Point newLocation = m_control.Location;
            newLocation.X = (int)(m_lastLocation.X + m_phaseDirection * m_phaseAmp * Math.Sin(m_phase));
            newLocation.Y = (int)(m_lastLocation.Y + m_phaseDirection * m_phaseAmp * Math.Cos(m_phase));

            m_control.Location = newLocation;
        }

        void StopTimerTick(object sender, EventArgs e)
        {
            m_control.Dock = m_lastDock;
            m_control.Location = m_lastLocation;
            m_control.Anchor = m_lasAnchorStyles;

            m_actionTimer.Stop();
            m_stopTimer.Stop();
            if (PartiesOver != null)
            {
                PartiesOver.Invoke(this, null);
            }
        }
    }
}