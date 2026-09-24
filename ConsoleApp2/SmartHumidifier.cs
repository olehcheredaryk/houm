using System;

namespace ConsoleApp2
{
    public class SmartHumidifier : IObserver
    {
        public void Update(double temperature, double humidity)
        {
            if (humidity < 40)
            {
                Console.WriteLine(
                    $"Зволожувач: вологість {humidity}%. Вмикаю зволоження.");
            }
            else
            {
                Console.WriteLine(
                    $"Зволожувач: вологість {humidity}%. Зволоження не потрібне.");
            }
        }
    }
}