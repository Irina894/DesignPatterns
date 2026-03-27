using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.behavioral.chainofresponsibility
{
    public class Handler100UAH : MoneyHandler
    {
        public Handler100UAH()
        {
            denomination = 100;
        }
    }
}
