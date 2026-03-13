using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DesignPatterns.structural.flyweight
{
    public class TreeFactory
    {
        private Dictionary<string, TreeType> treeTypes = new Dictionary<string, TreeType>();

        public TreeType GetTreeType(string name, string barkTexture, string leafShape, string woodType)
        {
            string key = $"{name}_{barkTexture}_{leafShape}_{woodType}";

            if (!treeTypes.ContainsKey(key))
            {
                treeTypes[key] = new TreeType(name, barkTexture, leafShape, woodType);
                Console.WriteLine($"Created new TreeType: {name}");
            }

            return treeTypes[key];
        }
    }
}