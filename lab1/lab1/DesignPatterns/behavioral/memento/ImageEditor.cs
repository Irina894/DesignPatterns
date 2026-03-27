using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.behavioral.memento
{
    public class ImageEditor
    {
        public int Brightness { get; private set; }
        public int Contrast { get; private set; }
        public List<string> Filters { get; private set; }

        public ImageEditor()
        {
            Brightness = 50;
            Contrast = 50;
            Filters = new List<string>();
        }

        public void SetBrightness(int brightness)
        {
            Brightness = brightness;
            Console.WriteLine($"Brightness set to {Brightness}");
        }

        public void SetContrast(int contrast)
        {
            Contrast = contrast;
            Console.WriteLine($"Contrast set to {Contrast}");
        }

        public void AddFilter(string filter)
        {
            Filters.Add(filter);
            Console.WriteLine($"Filter added: {filter}");
        }

        public EditorMemento Save()
        {
            Console.WriteLine("Saving editor state...");
            return new EditorMemento(Brightness, Contrast, Filters);
        }

        public void Restore(EditorMemento memento)
        {
            Brightness = memento.Brightness;
            Contrast = memento.Contrast;
            Filters = new List<string>(memento.Filters);
            Console.WriteLine("Editor state restored.");
        }

        public void ShowState()
        {
            Console.WriteLine($"Brightness: {Brightness}");
            Console.WriteLine($"Contrast: {Contrast}");
            Console.WriteLine("Filters: " + (Filters.Count > 0 ? string.Join(", ", Filters) : "None"));
        }
    }
}
