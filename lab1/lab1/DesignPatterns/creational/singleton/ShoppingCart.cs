using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.creational.singleton
{
    public class ShoppingCart
    {
        private static ShoppingCart? instance;

        private List<string> items = new List<string>();

        private ShoppingCart()
        {
        }

        public static ShoppingCart GetInstance()
        {
            if (instance == null)
            {
                instance = new ShoppingCart();
            }

            return instance;
        }

        public void AddItem(string item)
        {
            items.Add(item);
            Console.WriteLine($"Added to cart: {item}");
        }

        public void ShowItems()
        {
            Console.WriteLine("Items in cart:");

            foreach (var item in items)
            {
                Console.WriteLine($"- {item}");
            }
        }
    }
}