namespace FacebookApp
{
    using System;
    using System.IO;
    using System.Media;

    public class MusicPlayer
    {
        public static Action OnPartyStart;
        public static Action OnPartyEnd;

        public void Start()
        {
            Stream str = Properties.Resources.skrillex;
            SoundPlayer snd = new SoundPlayer(str);
            snd.Play();
            if (OnPartyStart != null)
            {
                OnPartyStart.Invoke();
            }
        }
    }
}