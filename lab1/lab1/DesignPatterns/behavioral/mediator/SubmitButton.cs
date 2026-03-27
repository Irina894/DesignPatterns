using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.behavioral.mediator
{
    public class SubmitButton : Component
    {
        public bool IsEnabled { get; private set; }

        public SubmitButton(IMediator mediator) : base(mediator)
        {
        }

        public void Enable()
        {
            IsEnabled = true;
            Console.WriteLine("Submit button ENABLED");
        }

        public void Disable()
        {
            IsEnabled = false;
            Console.WriteLine("Submit button DISABLED");
        }

        public void Click()
        {
            Console.WriteLine("Submit button clicked");
            mediator.Notify(this, "SubmitClicked");
        }
    }
}
