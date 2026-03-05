using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.creational.factory_method
{
    public class SmsNotificationCreator : NotificationCreator
    {
        public override Notification FactoryMethod()
        {
            return new SmsNotification();
        }
    }
}
