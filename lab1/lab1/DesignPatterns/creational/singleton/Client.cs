using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.creational.singleton
{
    public class Client
    {
        public static void Run()
        {
            ShoppingCart cart1 = ShoppingCart.GetInstance();
            cart1.AddItem("Laptop");
            cart1.AddItem("Mouse");

            ShoppingCart cart2 = ShoppingCart.GetInstance();
            cart2.AddItem("Keyboard");

            cart2.ShowItems();

            Console.WriteLine();
        }
    }
}