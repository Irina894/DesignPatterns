using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DesignPatterns.creational.abstract_factory
{
    public class Client
    {
        public static void Run(IUIFactory factory)
        {
            IButton button = factory.CreateButton();
            ICheckbox checkbox = factory.CreateCheckbox();
            ITextField textField = factory.CreateTextField();

            button.Render();
            checkbox.Render();
            textField.Render();
        }
    }
}
