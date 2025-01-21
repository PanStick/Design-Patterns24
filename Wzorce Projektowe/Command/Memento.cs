using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wzorce_Projektowe.Command
{
    internal class Memento(State s)
    {
        State s = s;

        public State GetState()
        {
            return s;
        }
        
    }
}
