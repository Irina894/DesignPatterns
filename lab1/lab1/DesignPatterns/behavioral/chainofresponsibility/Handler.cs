using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.behavioral.chainofresponsibility
{
    public abstract class Handler
    {
        protected Handler? nextHandler;

        public void SetNext(Handler nextHandler)
        {
            this.nextHandler = nextHandler;
        }

        public abstract void Handle(int amount);
    }
}
