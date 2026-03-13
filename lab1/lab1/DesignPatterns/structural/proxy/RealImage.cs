using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.structural.proxy
{
    public class RealImage : IImage
    {
        private string fileName;

        public RealImage(string fileName)
        {
            this.fileName = fileName;
            LoadFromServer();
        }

        private void LoadFromServer()
        {
            Console.WriteLine($"Loading large image '{fileName}' from server...");
        }

        public void Display()
        {
            Console.WriteLine($"Displaying real image: {fileName}");
        }
    }
}