using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.behavioral.chainofresponsibility
{
    public class Handler500UAH : MoneyHandler
    {
        public Handler500UAH()
        {
            denomination = 500;
        }
    }
}
