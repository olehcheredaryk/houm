using System;

namespace ConsoleApp2
{
    internal class SmartHumidifier : IObserver
    {
        public string Name { get; } = "Зволожувач повітря";

        public void Update(double temperature, double humidity)
        {
            if (humidity < 40.0)
            {
                Console.WriteLine($"  -> {Name}: Низька вологість ({humidity}%). Починаю зволоження кімнати.");
            }
            else
            {
                Console.WriteLine($"  -> {Name}: Вологість в нормі ({humidity}%). Вимикаюся.");
            }
        }
    }
}
