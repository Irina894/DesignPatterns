using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.creational.prototype
{
    public class Monster : IPrototype<Monster>
    {
        public int Health { get; set; }
        public int Mana { get; set; }

        public string Texture { get; set; } = "";
        public string AnimationSet { get; set; } = "";

        public int X { get; set; }
        public int Y { get; set; }

        public Monster Clone()
        {
            return (Monster)this.MemberwiseClone();
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Monster HP:{Health} Mana:{Mana} Texture:{Texture} Position({X},{Y})");
        }
    }
}
