using System;

namespace ConsoleApp2
{
    internal class SmartAirConditioner : IObserver
    {
        public string Name { get; } = "Кондиціонер";

        public void Update(double temperature, double humidity)
        {
            if (temperature > 25.0)
            {
                Console.WriteLine($"  -> {Name}: Температура {temperature}°C занадто висока! Вмикаю охолодження.");
            }
            else if (temperature < 18.0)
            {
                Console.WriteLine($"  -> {Name}: Температура {temperature}°C занадто низька! Вмикаю обігрів.");
            }
            else
            {
                Console.WriteLine($"  -> {Name}: Температура в нормі ({temperature}°C). Режим очікування.");
            }
        }
    }
}
