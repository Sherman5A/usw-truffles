using System.Media;

namespace USWGame
{
    internal class Sound
    {
        public static void PlaySound(Stream audio)
        {
            using SoundPlayer player = new SoundPlayer(audio);
            player.Play();
        }
    }
}
