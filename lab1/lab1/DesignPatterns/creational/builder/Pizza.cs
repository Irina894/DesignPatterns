using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.creational.builder
{
    public class Pizza
    {
        public string Dough { get; set; }
        public bool Sauce { get; set; }
        public bool Cheese { get; set; }
        public bool DoubleMeat { get; set; }
        public bool Mushrooms { get; set; }
        public bool Pineapple { get; set; }
        public bool CheeseCrust { get; set; }

        public double Price { get; set; }

        public void ShowPizza()
        {
            Console.WriteLine("Pizza configuration:");

            Console.WriteLine($"Dough: {Dough}");

            if (Sauce) Console.WriteLine("Sauce added");
            if (Cheese) Console.WriteLine("Cheese added");
            if (DoubleMeat) Console.WriteLine("Double meat added");
            if (Mushrooms) Console.WriteLine("Mushrooms added");
            if (Pineapple) Console.WriteLine("Pineapple added");
            if (CheeseCrust) Console.WriteLine("Cheese crust added");

            Console.WriteLine($"Total price: {Price}$");
        }
    }
}
