﻿using System;
using System.Drawing;
using System.Windows.Forms;

namespace FacebookApp
{
    public class ComponentDanceMachine
    {
        private const int k_TotalPartyTime = 16000;

        private const int k_ActionDuration = 20;

        private Control m_Control;

        private Timer m_ActionTimer;

        private DockStyle m_LastDock;

        private Point m_LastLocation;

        private AnchorStyles m_LastAnchorStyles;

        private int m_Phase = 0;

        private int m_PhaseDirection = 1;

        private int m_PhaseAmp = 20;

        public ComponentDanceMachine(Control i_Control)
        {
            m_Control = i_Control;
            DJObserverable.OnPartyStart += OnPartyStart;
            DJObserverable.OnPartyEnd += OnPartyEnd;
        }

        /// <summary>
        /// Party for 10 seconds
        /// </summary>
        private void StartDancing()
        {
            Random rand = new Random();
            m_PhaseAmp = rand.Next(2, 20); // between 5- 20
            m_PhaseDirection = (rand.Next(100) > 50) ? 1 : -1; // clockwise or counter clockwise

            m_LastDock = m_Control.Dock;
            m_LastLocation = m_Control.Location;
            m_LastAnchorStyles = m_Control.Anchor;
            m_Control.Dock = DockStyle.None;
            m_Control.Anchor = AnchorStyles.None;

            m_ActionTimer = new Timer();
            m_ActionTimer.Interval = k_ActionDuration;
            m_ActionTimer.Tick += ActionTimerOnTick;

            m_ActionTimer.Start();
        }

        private void ActionTimerOnTick(object i_Sender, EventArgs i_EventArgs)
        {
            m_Phase++;
            Point newLocation = m_Control.Location;
            newLocation.X = (int)(m_LastLocation.X + (m_PhaseDirection * m_PhaseAmp * Math.Sin(m_Phase)));
            newLocation.Y = (int)(m_LastLocation.Y + (m_PhaseDirection * m_PhaseAmp * Math.Cos(m_Phase)));

            m_Control.Location = newLocation;
        }

        private void OnPartyStart()
        {
            StartDancing();
        }

        private void OnPartyEnd()
        {
            m_ActionTimer.Stop();

            m_Control.Dock = m_LastDock;
            m_Control.Location = m_LastLocation;
            m_Control.Anchor = m_LastAnchorStyles;
        }
    }
}