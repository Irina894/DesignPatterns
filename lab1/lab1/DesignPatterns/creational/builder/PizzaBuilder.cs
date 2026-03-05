using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.creational.builder
{
    public class PizzaBuilder
    {
        private Pizza pizza = new Pizza();

        public PizzaBuilder AddThinDough()
        {
            pizza.Dough = "Thin";
            pizza.Price += 5;
            return this;
        }

        public PizzaBuilder AddThickDough()
        {
            pizza.Dough = "Thick";
            pizza.Price += 6;
            return this;
        }

        public PizzaBuilder AddSauce()
        {
            pizza.Sauce = true;
            pizza.Price += 1;
            return this;
        }

        public PizzaBuilder AddCheese()
        {
            pizza.Cheese = true;
            pizza.Price += 2;
            return this;
        }

        public PizzaBuilder AddDoubleMeat()
        {
            pizza.DoubleMeat = true;
            pizza.Price += 4;
            return this;
        }

        public PizzaBuilder AddMushrooms()
        {
            pizza.Mushrooms = true;
            pizza.Price += 2;
            return this;
        }

        public PizzaBuilder AddPineapple()
        {
            pizza.Pineapple = true;
            pizza.Price += 2;
            return this;
        }

        public PizzaBuilder AddCheeseCrust()
        {
            pizza.CheeseCrust = true;
            pizza.Price += 3;
            return this;
        }

        public Pizza Build()
        {
            return pizza;
        }
    }
}