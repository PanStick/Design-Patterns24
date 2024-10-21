using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wzorce_Projektowe.Adapter
{
    class Racetrack
    {
        public List<Vehicle> Vehicles { get; set; }

        public Racetrack() { Vehicles = new List<Vehicle>(); }
    }
}
