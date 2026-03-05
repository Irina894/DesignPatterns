using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.creational.factory_method
{
    public class TelegramNotification : Notification
    {
        public override void Send(string message)
        {
            Console.WriteLine($"Sending TELEGRAM notification: {message}");
        }
    }
}
