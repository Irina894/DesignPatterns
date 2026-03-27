using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.behavioral.state
{
    public class PlayingState : IPlayerState
    {
        public void PlayPause(AudioPlayer player)
        {
            Console.WriteLine("Pausing playback...");
            player.SetState(new PausedState());
        }

        public void Stop(AudioPlayer player)
        {
            Console.WriteLine("Stopping playback...");
            player.SetState(new StoppedState());
        }

        public void Rewind(AudioPlayer player)
        {
            Console.WriteLine("Rewinding audio...");
            player.SetState(new RewindingState());
        }
    }
}
