using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.behavioral.observer
{
    public class Client
    {
        public static void Run()
        {
            Parcel parcel = new Parcel("UA123456789");

            Customer customer = new Customer("Iryna");
            WarehouseManager manager = new WarehouseManager("Oleh");

            parcel.Attach(customer);
            parcel.Attach(manager);

            parcel.SetStatus("Arrived at warehouse");
            parcel.SetStatus("Out for delivery");
            parcel.SetStatus("Delivered");

            Console.WriteLine();
        }
    }
}