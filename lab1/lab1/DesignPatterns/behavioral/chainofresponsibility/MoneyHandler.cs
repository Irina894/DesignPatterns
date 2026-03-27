using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.behavioral.chainofresponsibility
{
    public abstract class MoneyHandler : Handler
    {
        protected int denomination;

        public override void Handle(int amount)
        {
            if (amount >= denomination)
            {
                int count = amount / denomination;
                int remainder = amount % denomination;

                Console.WriteLine($"Dispensing {count} banknotes of {denomination} UAH");

                if (remainder != 0 && nextHandler != null)
                {
                    nextHandler.Handle(remainder);
                }
                else if (remainder != 0)
                {
                    Console.WriteLine($"Cannot dispense remaining amount: {remainder} UAH");
                }
            }
            else if (nextHandler != null)
            {
                nextHandler.Handle(amount);
            }
            else
            {
                Console.WriteLine($"Cannot dispense amount: {amount} UAH");
            }
        }
    }
}
