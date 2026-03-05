using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.creational.factory_method
{
    public abstract class NotificationCreator
    {
        public abstract Notification FactoryMethod();

        public void SendNotification(string message)
        {
            Notification notification = FactoryMethod();
            notification.Send(message);
        }
    }
}
