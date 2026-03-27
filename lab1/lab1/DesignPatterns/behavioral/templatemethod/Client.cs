using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.behavioral.templatemethod
{
    public class Client
    {
        public static void Run()
        {

            Console.WriteLine("\nMaking coffee:");
            CaffeineBeverage coffee = new Coffee();
            coffee.PrepareRecipe();

            Console.WriteLine("\nMaking tea:");
            CaffeineBeverage tea = new Tea();
            tea.PrepareRecipe();

            Console.WriteLine();
        }
    }
}
