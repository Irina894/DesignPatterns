using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.creational.factory_method
{
    public class Client
    {
        public static void Run()
        {
            NotificationCreator creator;

            creator = new EmailNotificationCreator();
            creator.SendNotification("Hello via Email!");

            creator = new SmsNotificationCreator();
            creator.SendNotification("Hello via SMS!");

            creator = new TelegramNotificationCreator();
            creator.SendNotification("Hello via Telegram!");
        }
    }
}
