using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.behavioral.strategy
{
    public class CryptoPayment : IPaymentStrategy
    {
        private string walletAddress;

        public CryptoPayment(string walletAddress)
        {
            this.walletAddress = walletAddress;
        }

        public void Pay(double amount)
        {
            Console.WriteLine($"Paid {amount}$ with Crypto");
            Console.WriteLine($"Wallet Address: {walletAddress}");
        }
    }
}
