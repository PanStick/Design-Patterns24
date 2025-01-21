using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wzorce_Projektowe.Builder
{
    interface IButtonsBuilder
    {
        List<string> AddButtons();
    }

    class StudentsButtonsBuilder : IButtonsBuilder
    {
        public List<string> AddButtons()
        {
            return new List<string>(["Plan zajec", "Sprawdziany", "Oceny"]);
        }
    }

    class AdminButtonsBuilder : IButtonsBuilder
    {
        public List<string> AddButtons()
        {
            return new List<string>(["Studenci", "Przedmioty"]);
        }
    }
}
