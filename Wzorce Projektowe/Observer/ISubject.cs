using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wzorce_Projektowe.Observer
{
    internal interface ISubject
    {
        void Register(IObserver o);
        void Unregister(IObserver o);
        void Notify(Weather w);
    }
}
