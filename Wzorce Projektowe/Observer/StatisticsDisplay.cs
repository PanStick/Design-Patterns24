using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wzorce_Projektowe.Observer
{
    internal class StatisticsDisplay : IObserver
    {
        List<Tuple<DateTime, Weather>> WeatherHistory = [];
        
        public StatisticsDisplay(ISubject s)
        {
            s.Register(this);
        }

        public void Update(Weather w) { WeatherHistory.Add(Tuple.Create(DateTime.Now, w)); }
        public void DisplayStats() 
        {
            foreach (var weather in WeatherHistory)
            {
                Console.WriteLine("Date: " + weather.Item1);
                Console.WriteLine("Humidity: " + weather.Item2.Humidity + "%");
                Console.WriteLine("Temperature: " + weather.Item2.Temperature + "C");
                Console.WriteLine("Pressure: " + weather.Item2.Pressure + "hpa\n");
            }
        }
    }
}
