using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.creational.abstract_factory
{
    public class WebFactory : IUIFactory
    {
        public IButton CreateButton()
        {
            return new WebButton();
        }

        public ICheckbox CreateCheckbox()
        {
            return new WebCheckbox();
        }

        public ITextField CreateTextField()
        {
            return new WebTextField();
        }
    }
}