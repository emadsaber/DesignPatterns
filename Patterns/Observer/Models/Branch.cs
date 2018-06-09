using DesignPatterns.Patterns.Observer.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Patterns.Observer.Models
{
    public class Branch : IObserver
    {
        private static int _idTracker = 0;
        public int Id { get; set; }
        public decimal IPhonePrice { get; set; }
        public decimal NexusPrice { get; set; }
        public decimal SamsungPrice { get; set; }

        public Branch(ISubject stock)
        {
            this.Id = ++_idTracker;

            Console.WriteLine($"New branch added. (Id: {this.Id})\n");

            stock.Register(this);
        }

        public void Update(decimal iphonePrice, decimal nexusPrice, decimal samsungPrice)
        {
            this.IPhonePrice = iphonePrice;
            this.NexusPrice = nexusPrice;
            this.SamsungPrice = samsungPrice;

            PrintPrices();
        }

        public void PrintPrices()
        {
            Console.Write($"Branch : {Id} - ");
            Console.Write($"IPhone Price : {IPhonePrice} - ");
            Console.Write($"Nexus Price : {NexusPrice} - ");
            Console.Write($"Samsung Price : {SamsungPrice}\n\n");
        }
    }
}
