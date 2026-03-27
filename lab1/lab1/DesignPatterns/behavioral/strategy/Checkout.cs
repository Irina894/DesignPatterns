using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.behavioral.strategy
{
    public class Checkout
    {
        private IPaymentStrategy paymentStrategy;

        public Checkout(IPaymentStrategy paymentStrategy)
        {
            this.paymentStrategy = paymentStrategy;
        }

        public void SetPaymentStrategy(IPaymentStrategy paymentStrategy)
        {
            this.paymentStrategy = paymentStrategy;
        }

        public void ProcessPayment(double amount)
        {
            Console.WriteLine("Processing payment...");
            paymentStrategy.Pay(amount);
        }
    }
}
