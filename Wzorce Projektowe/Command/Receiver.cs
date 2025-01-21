using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wzorce_Projektowe.Command
{
    internal class Receiver
    {
        State s;
        readonly Caretaker _caretaker;
       public Receiver(Caretaker caretaker)
        {
            _caretaker = caretaker;
        }
        public void SetLights(bool v)
        {
            CreateMemento();
            s.lights = v;
            Console.Write("Lights turned");
            if (v) Console.WriteLine(" on");
            else Console.WriteLine(" off");
        }

        public void SetTemperature(double temperature)
        {
            CreateMemento();
            s.temperature = temperature;
            Console.WriteLine("Temperature set to " + temperature);
        }
        public void CreateMemento()
        {
            _caretaker.Push(new Memento(s));
        }
        public void SetMemento()
        {
            s = _caretaker.Pop().GetState();
            Console.WriteLine("Previous state restored");
            Console.WriteLine("Temperature: " + s.temperature);
            Console.WriteLine("Lights: " + s.lights);
        }


    }
}
