using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MementoPattern
{
    public class Memento
    {
        public string State { get; }    

        public Memento(string state)
        {
            State = state;
        }

        
    }
}
