using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MementoPattern
{
    public class Caretaker
    {
        private List<Memento> mementos = new List<Memento>();

        public void Push(Memento memento)
        {
            mementos.Add(memento);
        }

        public Memento Pop()
        {
            var lastIndex = mementos.Count - 1;
            var lastMemento = mementos[lastIndex];
            mementos.RemoveAt(lastIndex);

            return lastMemento;
        }
    }
}
