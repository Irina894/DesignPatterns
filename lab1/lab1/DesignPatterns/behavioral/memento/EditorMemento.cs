using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.behavioral.memento
{
    public class EditorMemento
    {
        public int Brightness { get; }
        public int Contrast { get; }
        public List<string> Filters { get; }

        public EditorMemento(int brightness, int contrast, List<string> filters)
        {
            Brightness = brightness;
            Contrast = contrast;
            Filters = new List<string>(filters);
        }
    }
}
