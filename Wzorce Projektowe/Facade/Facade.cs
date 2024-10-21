using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace Wzorce_Projektowe.Facade
{
    class Facade
    {
        Patron _patron;
        PatronRecord _patronRecord;
        public Facade() { _patron = new(); _patronRecord = new(); }
        public void Search() { _patron.Search(); }
        public void RetrieveMember() { _patronRecord.RetrieveMember(); }
    }
}
