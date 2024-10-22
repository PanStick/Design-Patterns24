using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wzorce_Projektowe.Observer
{
    internal class CurrentConditions : IObserver
    {
        Weather _data;

        public CurrentConditions(ISubject s)
        {
            s.Register(this);
        }

        public void Update(Weather data)
        {
            _data = data;
        }
        public void Display()
        {
            Console.WriteLine("Humidity: " + _data.Humidity + "%");
            Console.WriteLine("Temperature: " + _data.Temperature + "C");
            Console.WriteLine("Pressure : " + _data.Pressure + "hpa");
        }
    }
}
