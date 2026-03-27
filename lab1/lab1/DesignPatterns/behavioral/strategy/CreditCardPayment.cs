using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.behavioral.strategy
{
    public class CreditCardPayment : IPaymentStrategy
    {
        private string cardNumber;
        private string cvv;

        public CreditCardPayment(string cardNumber, string cvv)
        {
            this.cardNumber = cardNumber;
            this.cvv = cvv;
        }

        public void Pay(double amount)
        {
            Console.WriteLine($"Paid {amount}$ by Credit Card");
            Console.WriteLine($"Card Number: {cardNumber}");
            Console.WriteLine($"CVV: {cvv}");
        }
    }
}
