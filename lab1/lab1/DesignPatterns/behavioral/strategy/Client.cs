using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.behavioral.strategy
{
    public class Client
    {
        public static void Run()
        {
            Checkout checkout = new Checkout(
                new CreditCardPayment("1234-5678-9012-3456", "123")
            );
            checkout.ProcessPayment(150.0);

            Console.WriteLine();

            checkout.SetPaymentStrategy(
                new PayPalPayment("user@example.com")
            );
            checkout.ProcessPayment(75.5);

            Console.WriteLine();

            checkout.SetPaymentStrategy(
                new CryptoPayment("0xA45F89BC123XYZ")
            );
            checkout.ProcessPayment(300.0);

            Console.WriteLine();
        }
    }
}
