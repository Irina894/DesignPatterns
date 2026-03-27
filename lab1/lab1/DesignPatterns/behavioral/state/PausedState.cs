using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.behavioral.state
{
    public class PausedState : IPlayerState
    {
        public void PlayPause(AudioPlayer player)
        {
            Console.WriteLine("Resuming playback...");
            player.SetState(new PlayingState());
        }

        public void Stop(AudioPlayer player)
        {
            Console.WriteLine("Stopping from pause...");
            player.SetState(new StoppedState());
        }

        public void Rewind(AudioPlayer player)
        {
            Console.WriteLine("Rewinding from pause...");
            player.SetState(new RewindingState());
        }
    }
}
