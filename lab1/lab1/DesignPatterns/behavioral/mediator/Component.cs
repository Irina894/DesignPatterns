using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.behavioral.mediator
{
    public abstract class Component
    {
        protected IMediator mediator;

        public Component(IMediator mediator)
        {
            this.mediator = mediator;
        }
    }
}
