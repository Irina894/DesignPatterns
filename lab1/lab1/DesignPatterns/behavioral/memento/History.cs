using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.behavioral.memento
{
    public class History
    {
        private Stack<EditorMemento> history = new Stack<EditorMemento>();

        public void Push(EditorMemento memento)
        {
            history.Push(memento);
        }

        public EditorMemento? Pop()
        {
            if (history.Count == 0)
            {
                return null;
            }

            return history.Pop();
        }
    }
}
