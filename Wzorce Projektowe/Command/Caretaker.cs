using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wzorce_Projektowe.Command
{
    internal class Caretaker
    {
        List<Memento> states;

        public Caretaker()
        {
            states = [];
        }

        public void Push(Memento s)
        {
            states.Add(s);
        }

        public Memento Pop()
        {
            Memento s = states.Last();
            states.RemoveAt(states.Count - 1);
            return s;
        }
    }
}
