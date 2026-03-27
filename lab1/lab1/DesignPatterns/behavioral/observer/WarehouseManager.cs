using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.behavioral.observer
{
    public class WarehouseManager : IObserver
    {
        private string name;

        public WarehouseManager(string name)
        {
            this.name = name;
        }

        public void Update(string parcelId, string status)
        {
            Console.WriteLine($"Warehouse Manager {name} sees update: Parcel {parcelId} status = '{status}'");
        }
    }
}
