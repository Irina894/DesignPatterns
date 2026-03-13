using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.structural.flyweight
{
    public class Client
    {
        public static void Run()
        {

            Forest forest = new Forest();

            forest.PlantTree(10, 20, 5, 3.5, "Oak", "Rough bark", "Rounded leaf", "Hardwood");
            forest.PlantTree(15, 25, 8, 4.2, "Oak", "Rough bark", "Rounded leaf", "Hardwood");
            forest.PlantTree(30, 40, 3, 2.8, "Pine", "Scaly bark", "Needle leaf", "Softwood");
            forest.PlantTree(50, 60, 10, 6.1, "Birch", "White bark", "Triangular leaf", "Hardwood");
            forest.PlantTree(70, 80, 6, 3.9, "Pine", "Scaly bark", "Needle leaf", "Softwood");

            forest.DisplayTrees();

            Console.WriteLine();
        }
    }
}