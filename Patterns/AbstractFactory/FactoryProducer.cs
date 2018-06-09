using DesignPatterns.Patterns.AbstractFactory.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Patterns.AbstractFactory
{
    public class FactoryProducer
    {
        public AbstractFactory.Contracts.AbstractFactory GetFactory(string factoryName)
        {
            switch (factoryName.ToLower())
            {
                case "shape":
                    return new ShapeFactory();
                case "color":
                    return new ColorFactory();
                default:
                    break;
            }
            return null;
        }
    }
}
