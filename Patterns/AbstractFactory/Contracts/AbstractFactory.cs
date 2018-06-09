using DesignPatterns.Patterns.AbstractFactory.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Patterns.AbstractFactory.Contracts
{
    public abstract class AbstractFactory
    {
        public abstract IColor GetColor(string name);
        public abstract IShape GetShape(string name);
    }
}