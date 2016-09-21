using System.Windows.Forms;

namespace FacebookApp
{
    using System;
    using System.IO;
    using System.Media;

    public class MusicPlayer
    {
        private const int k_TotalPartyTime = 16000;
        public static Action OnPartyStart;
        public static Action OnPartyEnd;
        private static Timer s_StopTimer;

        public static void Start()
        {
            Stream str = Properties.Resources.skrillex;
            SoundPlayer snd = new SoundPlayer(str);
            s_StopTimer = new Timer();
            s_StopTimer.Interval = k_TotalPartyTime;
            s_StopTimer.Tick += SStopTimerOnTick;
            s_StopTimer.Start();

            snd.Play();
            if (OnPartyStart != null)
            {
                OnPartyStart.Invoke();
            }
        }

        private static void SStopTimerOnTick(object sender, EventArgs eventArgs)
        {
            s_StopTimer.Stop();
            if (OnPartyEnd != null)
            {
                OnPartyEnd.Invoke();
            }
        }
    }
}