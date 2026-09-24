using System;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            // Створюємо центральний хаб
            ClimateHub hub = new ClimateHub();

            // Створюємо смарт-пристрої
            IObserver airConditioner = new SmartAirConditioner();
            IObserver humidifier = new SmartHumidifier();

            // Підключаємо пристрої до хабу
            hub.RegisterObserver(airConditioner);
            hub.RegisterObserver(humidifier);

            // Змінюємо показники клімату
            Console.WriteLine("\n--- Перша зміна клімату ---");
            hub.SetClimateData(28.5, 35.0);

            // Відключаємо кондиціонер
            Console.WriteLine("\n--- Відключення кондиціонера ---");
            hub.RemoveObserver(airConditioner);

            // Знову змінюємо показники
            Console.WriteLine("\n--- Друга зміна клімату ---");
            hub.SetClimateData(16.0, 60.0);

            Console.WriteLine("\nНатисніть будь-яку клавішу для виходу...");
            Console.ReadKey();
        }
    }
}