using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.structural.flyweight
{
    public class TreeType
    {
        public string Name { get; private set; }
        public string BarkTexture { get; private set; }
        public string LeafShape { get; private set; }
        public string WoodType { get; private set; }

        public TreeType(string name, string barkTexture, string leafShape, string woodType)
        {
            Name = name;
            BarkTexture = barkTexture;
            LeafShape = leafShape;
            WoodType = woodType;
        }

        public void Display(int x, int y, int age, double height)
        {
            Console.WriteLine(
                $"Tree: {Name}, Bark: {BarkTexture}, Leaf: {LeafShape}, Wood: {WoodType}, " +
                $"Position: ({x}, {y}), Age: {age}, Height: {height}m");
        }
    }
}