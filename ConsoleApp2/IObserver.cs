using System;

namespace ConsoleApp2
{
    internal interface IObserver
    {
        string Name { get; }
        void Update(double temperature, double humidity);
    }
}
