using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.creational.prototype
{
    public class Client
    {
        public static void Run()
        {

            Monster baseMonster = new Monster
            {
                Health = 100,
                Mana = 50,
                Texture = "OrcTexture.png",
                AnimationSet = "OrcAnimations"
            };

            Monster monster1 = baseMonster.Clone();
            monster1.X = 10;
            monster1.Y = 20;

            Monster monster2 = baseMonster.Clone();
            monster2.X = 30;
            monster2.Y = 40;

            Monster monster3 = baseMonster.Clone();
            monster3.X = 50;
            monster3.Y = 60;

            baseMonster.ShowInfo();
            monster1.ShowInfo();
            monster2.ShowInfo();
            monster3.ShowInfo();

            Console.WriteLine();
        }
    }
}