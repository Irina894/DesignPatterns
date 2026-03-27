using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.behavioral.state
{
    public class AudioPlayer
    {
        private IPlayerState state;

        public AudioPlayer()
        {
            state = new StoppedState();
        }

        public void SetState(IPlayerState newState)
        {
            state = newState;
        }

        public void PressPlayPause()
        {
            state.PlayPause(this);
        }

        public void PressStop()
        {
            state.Stop(this);
        }

        public void PressRewind()
        {
            state.Rewind(this);
        }
    }
}