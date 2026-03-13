using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.structural.facade
{
    public class Light
    {
        public void Off()
        {
            Console.WriteLine("Lights turned OFF");
        }
    }
}
