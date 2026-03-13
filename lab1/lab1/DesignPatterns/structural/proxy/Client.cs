using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.structural.proxy
{
    public class Client
    {
        public static void Run()
        {

            ImagePlaceholderProxy image = new ImagePlaceholderProxy("forest_photo_hd.jpg");

            image.ShowPreview();

            Console.WriteLine("User scrolls image into visible area...");

            image.Display();

            Console.WriteLine("User opens image again...");
            image.Display();

            Console.WriteLine();
        }
    }
}