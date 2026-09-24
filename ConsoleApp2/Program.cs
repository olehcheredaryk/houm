using System;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Налаштування для коректного відображення українських літер в консолі
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            // 1. Створюємо центральний хаб
            ClimateHub hub = new ClimateHub();

            // 2. Створюємо смарт-пристрої
            IObserver airConditioner = new SmartAirConditioner();
            IObserver humidifier = new SmartHumidifier();

            // 3. Підключаємо пристрої до хабу
            hub.RegisterObserver(airConditioner);
            hub.RegisterObserver(humidifier);

            // 4. Зміна погоди (спекотно і сухо) -> Обидва пристрої мають зреагувати
            hub.SetClimateData(28.5, 35.0);

            // 5. Динамічно відключаємо кондиціонер
            hub.RemoveObserver(airConditioner);

            // 6. Зміна погоди (холодно і волого) -> Зреагує тільки зволожувач
            hub.SetClimateData(16.0, 60.0);

            Console.WriteLine("\nНатисніть будь-яку клавішу для виходу...");
            Console.ReadKey();
        }
    }
}
