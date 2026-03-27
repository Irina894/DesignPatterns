using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.behavioral.state
{
    public interface IPlayerState
    {
        void PlayPause(AudioPlayer player);
        void Stop(AudioPlayer player);
        void Rewind(AudioPlayer player);
    }
}
