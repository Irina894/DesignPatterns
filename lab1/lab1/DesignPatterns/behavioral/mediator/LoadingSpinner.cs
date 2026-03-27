using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.behavioral.mediator
{
    public class LoadingSpinner : Component
    {
        public LoadingSpinner(IMediator mediator) : base(mediator)
        {
        }

        public void Show()
        {
            Console.WriteLine("Loading spinner shown");
        }

        public void Hide()
        {
            Console.WriteLine("Loading spinner hidden");
        }
    }
}
