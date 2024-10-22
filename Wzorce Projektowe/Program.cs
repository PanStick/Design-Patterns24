using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wzorce_Projektowe.Observer;

namespace Wzorce_Projektowe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WeatherData weather = new();
            CurrentConditions current = new(weather);
            StatisticsDisplay statistics = new(weather);
            weather.Notify(new(weather.GetHumidity(), weather.GetTemperature(), weather.GetPressure()));
            current.Display();
            statistics.DisplayStats();
            Task.Delay(1000).Wait();
            weather.Notify(new(weather.GetHumidity(), weather.GetTemperature(), weather.GetPressure()));
            current.Display();
            statistics.DisplayStats();

        }
    }
}
