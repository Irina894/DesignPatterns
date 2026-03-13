using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.structural.facade
{
    public class Client
    {
        public static void Run()
        {
            SmartHomeFacade home = new SmartHomeFacade();

            home.LeaveHome();

            Console.WriteLine();
        }
    }
}