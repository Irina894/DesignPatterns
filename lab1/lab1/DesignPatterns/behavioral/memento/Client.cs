using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.behavioral.memento
{
    public class Client
    {
        public static void Run()
        {
            ImageEditor editor = new ImageEditor();
            History history = new History();

            Console.WriteLine("Initial state:");
            editor.ShowState();

            Console.WriteLine();

            history.Push(editor.Save());
            editor.SetBrightness(70);
            editor.AddFilter("Black & White");

            Console.WriteLine();
            Console.WriteLine("After first edit:");
            editor.ShowState();

            Console.WriteLine();

            history.Push(editor.Save());
            editor.SetContrast(80);
            editor.AddFilter("Vintage");

            Console.WriteLine();
            Console.WriteLine("After second edit:");
            editor.ShowState();

            Console.WriteLine();
            Console.WriteLine("Undo last change...");

            EditorMemento? previousState = history.Pop();
            if (previousState != null)
            {
                editor.Restore(previousState);
            }

            Console.WriteLine();
            Console.WriteLine("State after undo:");
            editor.ShowState();

            Console.WriteLine();
        }
    }
}
