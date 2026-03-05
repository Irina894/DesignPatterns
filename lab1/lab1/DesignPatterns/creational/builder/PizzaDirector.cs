using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.creational.builder
{
    public class PizzaDirector
    {
        public Pizza MakePepperoniPizza(PizzaBuilder builder)
        {
            return builder
                .AddThinDough()
                .AddSauce()
                .AddCheese()
                .AddDoubleMeat()
                .Build();
        }

        public Pizza MakeVegetarianPizza(PizzaBuilder builder)
        {
            return builder
                .AddThinDough()
                .AddSauce()
                .AddCheese()
                .AddMushrooms()
                .Build();
        }
    }
}
