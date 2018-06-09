using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Patterns.Observer.Contracts
{
    public interface IObserver
    {
        int Id { set; get; }
        void Update(decimal iphonePrice, decimal nexusPrice, decimal samsungPrice);
    }
}
