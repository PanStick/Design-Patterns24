using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wzorce_Projektowe.Builder
{
    interface IWelcomeMessageBuilder
    {
        string PrintWM();
    }

    class StudentsWMBuilder : IWelcomeMessageBuilder
    {
        public string PrintWM() { return "Witaj studencie"; }
    }

    class AdminWMBuilder : IWelcomeMessageBuilder
    {
        public string PrintWM() { return "Witaj adminie"; }
    }
}
