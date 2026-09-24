using System;

namespace ConsoleApp2
{
    public class SmartAirConditioner : IObserver
    {
        public void Update(double temperature, double humidity)
        {
            if (temperature > 25)
            {
                Console.WriteLine(
                    $"Кондиціонер: температура {temperature}°C. Вмикаю охолодження.");
            }
            else
            {
                Console.WriteLine(
                    $"Кондиціонер: температура {temperature}°C. Охолодження не потрібне.");
            }
        }
    }
}