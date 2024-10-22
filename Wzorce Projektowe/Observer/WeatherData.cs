using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wzorce_Projektowe.Observer
{
    struct Weather
    {
        public int Humidity { get; set; } //%
        public int Temperature { get; set; }
        public int Pressure { get; set; } //hpa

        public Weather(int humidity, int temperature, int pressure)
        {
            Humidity = humidity;
            Temperature = temperature;
            Pressure = pressure;
        }
    }

    internal class WeatherData : ISubject
    {
        List<IObserver> _observers = [];
        Random WeatherGenerator = new();
        public void Register(IObserver o) { _observers.Add(o); }
        public void Unregister(IObserver o) { _observers.Remove(o); }
        public void Notify(Weather w)
        {
            foreach (IObserver o in _observers)
                o.Update(w);
        }

        public int GetHumidity() { return WeatherGenerator.Next(20, 70); }
        public int GetTemperature() { return WeatherGenerator.Next(-20, 40); }
        public int GetPressure() { return WeatherGenerator.Next(980, 1020); }
    }
}
