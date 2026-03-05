using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.creational.factory_method
{
    public class SmsNotification : Notification
    {
        public override void Send(string message)
        {
            Console.WriteLine($"Sending SMS notification: {message}");
        }
    }
}
