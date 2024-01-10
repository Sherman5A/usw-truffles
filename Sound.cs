using System.Media;

namespace USWGame
{
    internal class Sound
    {
        public static SoundPlayer PlaySound(Stream audio)
        {
            using SoundPlayer player = new SoundPlayer(audio);
            player.Play();
            return player;
        }
    }
}
