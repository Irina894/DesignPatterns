using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.behavioral.strategy
{
    public class PayPalPayment : IPaymentStrategy
    {
        private string email;

        public PayPalPayment(string email)
        {
            this.email = email;
        }

        public void Pay(double amount)
        {
            Console.WriteLine($"Paid {amount}$ via PayPal");
            Console.WriteLine($"PayPal Email: {email}");
        }
    }
}
