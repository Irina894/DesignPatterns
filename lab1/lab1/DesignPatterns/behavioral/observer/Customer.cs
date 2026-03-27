using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.behavioral.observer
{
    public class Customer : IObserver
    {
        private string name;

        public Customer(string name)
        {
            this.name = name;
        }

        public void Update(string parcelId, string status)
        {
            Console.WriteLine($"Customer {name} received update: Parcel {parcelId} is now '{status}'");
        }
    }
}