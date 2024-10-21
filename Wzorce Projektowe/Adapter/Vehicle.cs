using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Wzorce_Projektowe.Adapter
{
    class Vehicle
    {
        LegacyCar LegacyCar { get; set; }

        public Vehicle() { LegacyCar = new LegacyCar(); }

        public void MoveTo(double locationX, double locationY)
        {
            LegacyCar.Drive(locationX - LegacyCar.X, locationY - LegacyCar.Y);
        }
        public void ShowCoordinates()
        {
            Console.WriteLine(LegacyCar.X + " " + LegacyCar.Y);
        }
    }
}
