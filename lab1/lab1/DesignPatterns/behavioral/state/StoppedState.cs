using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.behavioral.state
{
    public class StoppedState : IPlayerState
    {
        public void PlayPause(AudioPlayer player)
        {
            Console.WriteLine("Starting playback...");
            player.SetState(new PlayingState());
        }

        public void Stop(AudioPlayer player)
        {
            Console.WriteLine("Already stopped.");
        }

        public void Rewind(AudioPlayer player)
        {
            Console.WriteLine("Cannot rewind. Player is stopped.");
        }
    }
}