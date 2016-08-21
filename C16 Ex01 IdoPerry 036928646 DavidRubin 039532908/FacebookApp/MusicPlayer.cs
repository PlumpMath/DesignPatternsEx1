namespace FacebookApp
{
    using System.IO;
    using System.Media;

    public class MusicPlayer
    {
        public MusicPlayer()
        {
            
        }

        public void Start()
        {
            Stream str = Properties.Resources.skrillex;
            SoundPlayer snd = new SoundPlayer(str);
            snd.Play();
        }
    }
}