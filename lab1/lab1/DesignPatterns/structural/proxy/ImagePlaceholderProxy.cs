using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.structural.proxy
{
    public class ImagePlaceholderProxy : IImage
    {
        private string fileName;
        private RealImage? realImage;

        public ImagePlaceholderProxy(string fileName)
        {
            this.fileName = fileName;
        }

        public void Display()
        {
            if (realImage == null)
            {
                Console.WriteLine("Loading placeholder...");
                realImage = new RealImage(fileName);
            }

            realImage.Display();
        }

        public void ShowPreview()
        {
            Console.WriteLine("Showing placeholder icon: [Loading image preview...]");
        }
    }
}
