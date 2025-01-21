using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wzorce_Projektowe.Command
{
    abstract class Command
    {
        protected Receiver r;
        protected Invoker i;
        public Command(Receiver r, Invoker i)
        {
            this.r = r;
            this.i = i;
        }

        public abstract void Execute();
    }
}
