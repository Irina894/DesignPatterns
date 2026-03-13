using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.structural.decorator
{
    public class SugarDecorator : CoffeeDecorator
    {
        public SugarDecorator(ICoffee coffee) : base(coffee) { }

        public override string GetDescription()
        {
            return coffee.GetDescription() + ", Sugar";
        }

        public override double GetCost()
        {
            return coffee.GetCost() + 0.2;
        }
    }
}