using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.creational.object_pool
{
    public class Equipment
    {
        public string Name { get; private set; }

        public Equipment(string name)
        {
            Name = name;
        }

        public void Use()
        {
            Console.WriteLine($"{Name} is being used.");
        }
    }
}
