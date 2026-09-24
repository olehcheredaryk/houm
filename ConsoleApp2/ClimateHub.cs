using System;
using System.Collections.Generic;

namespace ConsoleApp2
{
    public class ClimateHub : ISubject
    {
        private readonly List<IObserver> observers = new List<IObserver>();

        private double temperature;
        private double humidity;

        public double Temperature => temperature;
        public double Humidity => humidity;

        public void RegisterObserver(IObserver observer)
        {
            if (!observers.Contains(observer))
            {
                observers.Add(observer);
                Console.WriteLine("Пристрій підключено до хабу.");
            }
        }

        public void RemoveObserver(IObserver observer)
        {
            if (observers.Contains(observer))
            {
                observers.Remove(observer);
                Console.WriteLine("Пристрій відключено від хабу.");
            }
        }

        public void NotifyObservers()
        {
            foreach (IObserver observer in observers)
            {
                observer.Update(temperature, humidity);
            }
        }

        public void SetClimateData(double temperature, double humidity)
        {
            this.temperature = temperature;
            this.humidity = humidity;

            Console.WriteLine(
                $"\nХаб: температура = {temperature}°C, вологість = {humidity}%");

            NotifyObservers();
        }
    }
}