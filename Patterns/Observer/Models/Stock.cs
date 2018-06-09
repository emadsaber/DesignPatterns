using DesignPatterns.Patterns.Observer.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Patterns.Observer.Models
{
    public class Stock : ISubject
    {
        private List<IObserver> _observers;
        private decimal _iPhonePrice;
        private decimal _nexusPrice;
        private decimal _samsungPrice;

        public decimal IPhonePrice { get => _iPhonePrice; set { _iPhonePrice = value; NotifyObservers(); } }
        public decimal NexusPrice { get => _nexusPrice; set { _nexusPrice = value; NotifyObservers(); } }
        public decimal SamsungPrice { get => _samsungPrice; set { _samsungPrice = value; NotifyObservers(); } }

        public Stock()
        {
            _observers = new List<IObserver>();
        }

        public void NotifyObservers()
        {
            foreach (var observer in _observers)
            {
                observer.Update(iphonePrice: IPhonePrice, nexusPrice: NexusPrice, samsungPrice: SamsungPrice);
            }
        }

        public void Register(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void Unregister(IObserver observer)
        {
            Console.WriteLine($"Branch removed. (Id: {observer.Id})\n");

            _observers.Remove(observer);
        }
    }
}
