using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.behavioral.chainofresponsibility
{
    public class Client
    {
        public static void Run()
        {
            Handler handler500 = new Handler500UAH();
            Handler handler200 = new Handler200UAH();
            Handler handler100 = new Handler100UAH();

            handler500.SetNext(handler200);
            handler200.SetNext(handler100);

            int amount = 700;
            Console.WriteLine($"Request to withdraw: {amount} UAH");

            handler500.Handle(amount);

            Console.WriteLine();
        }
    }
}
