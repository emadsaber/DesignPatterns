using DesignPatterns.Patterns.AbstractFactory.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Patterns.AbstractFactory.Models
{
    class Circle : IShape
    {
        public void Draw()
        {
            Console.WriteLine("Drawing a circle shape");
        }
    }
}
