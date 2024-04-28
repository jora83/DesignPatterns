using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MementoPattern
{
    public class Originator
    {
        private string state;
        public string State
        {
            get { return state; }
            set
            {
                Console.WriteLine("Setting state to: " + value);
                state = value;
            }
        }
        
        public Memento CreateMemento()
        {
            return new Memento(state);
        }

        public void RestoreMemento(Memento memento)
        {
            state = memento.State;
            Console.WriteLine("State restored to: " + state);
        }

       
    }
}
