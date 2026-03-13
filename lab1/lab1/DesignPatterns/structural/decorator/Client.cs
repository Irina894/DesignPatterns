using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.structural.decorator
{
    public class Client
    {
        public static void Run()
        {

            ICoffee coffee = new SimpleCoffee();

            coffee = new MilkDecorator(coffee);
            coffee = new SugarDecorator(coffee);
            coffee = new MilkDecorator(coffee);

            Console.WriteLine(coffee.GetDescription());
            Console.WriteLine($"Total cost: ${coffee.GetCost()}");

            Console.WriteLine();
        }
    }
}
