using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wzorce_Projektowe.Observer
{
    internal interface IObserver
    {
        void Update(Weather w);
    }
}
