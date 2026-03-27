using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.behavioral.state
{
    public class Client
    {
        public static void Run()
        {

            AudioPlayer player = new AudioPlayer();

            player.PressPlayPause(); // старт
            player.PressPlayPause(); // пауза
            player.PressPlayPause(); // продовжити
            player.PressRewind();    // перемотка
            player.PressStop();      // стоп

            Console.WriteLine();
        }
    }
}
