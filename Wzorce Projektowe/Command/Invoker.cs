using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wzorce_Projektowe.Command
{
    struct State
    {
        public bool lights;
        public double temperature;
    }

    internal class Invoker
    {
        State s;
        public void ExecuteCommand(Command c)
        {
            c.Execute();
        }
        public void SetLights(bool lights)
        {
            s.lights = lights;
        }
        public void SetTemperature(double temperature)
        {
            s.temperature = temperature;
        }
        public bool GetLights() { return s.lights; }
        public double GetTemperature() { return s.temperature; }

    }
}
