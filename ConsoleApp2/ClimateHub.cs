using System;
using System.Collections.Generic;

namespace ConsoleApp2
{
    internal class ClimateHub : ISubject
    {
        private readonly List<IObserver> _observers = new List<IObserver>();
        private double _temperature;
        private double _humidity;

        public void RegisterObserver(IObserver observer)
        {
            if (!_observers.Contains(observer))
            {
                _observers.Add(observer);
                Console.WriteLine($"[ХАБ]: Пристрій '{observer.Name}' успішно підключено.");
            }
        }

        public void RemoveObserver(IObserver observer)
        {
            if (_observers.Contains(observer))
            {
                _observers.Remove(observer);
                Console.WriteLine($"[ХАБ]: Пристрій '{observer.Name}' відключено.");
            }
        }

        public void NotifyObservers()
        {
            foreach (var observer in _observers)
            {
                observer.Update(_temperature, _humidity);
            }
        }

        // Метод для зміни показників
        public void SetClimateData(double temperature, double humidity)
        {
            Console.WriteLine($"\n[ХАБ]: Зміна показників -> Температура: {temperature}°C, Вологість: {humidity}%");
            _temperature = temperature;
            _humidity = humidity;
            NotifyObservers();
        }
    }
}
