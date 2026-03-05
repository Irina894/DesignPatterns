using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.creational.builder
{
    public class Client
    {
        public static void Run()
        {

            PizzaBuilder builder = new PizzaBuilder();

            Pizza customPizza = builder
                .AddThinDough()
                .AddSauce()
                .AddCheese()
                .AddMushrooms()
                .AddCheeseCrust()
                .Build();

            customPizza.ShowPizza();

            Console.WriteLine();
        }
    }
}
