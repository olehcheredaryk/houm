using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    internal interface ISubject
    {
        void RegisterObserver(IObserver observer);
        void RemoveObserver(IObserver observer);
        void NotifyObservers();
    }
}
