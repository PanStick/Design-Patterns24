using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Wzorce_Projektowe.Adapter
{
    class LegacyCar
    {
        public double X { get; set; }
        public double Y { get; set; }

        public void Drive(double x, double y)
        {
            X += x;
            Y += y;
        }
    }
}
