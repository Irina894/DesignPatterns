using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.behavioral.mediator
{
    public class CheckBox : Component
    {
        public bool IsChecked { get; private set; }

        public CheckBox(IMediator mediator) : base(mediator)
        {
        }

        public void SetChecked(bool value)
        {
            IsChecked = value;
            Console.WriteLine($"CheckBox changed: {(IsChecked ? "Checked" : "Unchecked")}");
            mediator.Notify(this, "CheckChanged");
        }
    }
}

