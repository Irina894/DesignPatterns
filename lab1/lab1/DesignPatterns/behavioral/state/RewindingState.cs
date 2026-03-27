using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.behavioral.state
{
    public class RewindingState : IPlayerState
    {
        public void PlayPause(AudioPlayer player)
        {
            Console.WriteLine("Stopping rewind and playing...");
            player.SetState(new PlayingState());
        }

        public void Stop(AudioPlayer player)
        {
            Console.WriteLine("Stopping rewind...");
            player.SetState(new StoppedState());
        }

        public void Rewind(AudioPlayer player)
        {
            Console.WriteLine("Already rewinding...");
        }
    }
}
