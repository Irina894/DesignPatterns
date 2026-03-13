using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.structural.flyweight
{
    public class Tree
    {
        private int x;
        private int y;
        private int age;
        private double height;
        private TreeType type;

        public Tree(int x, int y, int age, double height, TreeType type)
        {
            this.x = x;
            this.y = y;
            this.age = age;
            this.height = height;
            this.type = type;
        }

        public void Display()
        {
            type.Display(x, y, age, height);
        }
    }
}