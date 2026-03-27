using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.behavioral.chainofresponsibility
{
    public class Handler200UAH : MoneyHandler
    {
        public Handler200UAH()
        {
            denomination = 200;
        }
    }
}
