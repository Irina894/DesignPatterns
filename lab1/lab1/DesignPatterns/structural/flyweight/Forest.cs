using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.structural.flyweight
{
    public class Forest
    {
        private List<Tree> trees = new List<Tree>();
        private TreeFactory factory = new TreeFactory();

        public void PlantTree(int x, int y, int age, double height,
            string name, string barkTexture, string leafShape, string woodType)
        {
            TreeType type = factory.GetTreeType(name, barkTexture, leafShape, woodType);
            Tree tree = new Tree(x, y, age, height, type);
            trees.Add(tree);
        }

        public void DisplayTrees()
        {
            foreach (var tree in trees)
            {
                tree.Display();
            }
        }
    }
}
