using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.creational.abstract_factory
{
    public class WebTextField : ITextField
    {
        public void Render()
        {
            Console.WriteLine("Rendering Web Material TextField");
        }
    }
}
