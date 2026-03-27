using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.behavioral.mediator
{
    public interface IMediator
    {
        void Notify(Component sender, string ev);
    }
}  

