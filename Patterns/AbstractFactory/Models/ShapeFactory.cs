using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns.Patterns.AbstractFactory.Contracts;

namespace DesignPatterns.Patterns.AbstractFactory.Models
{
    public class ShapeFactory : Contracts.AbstractFactory
    {
        public override IColor GetColor(string name)
        {
            throw new NotImplementedException();
        }

        public override IShape GetShape(string name)
        {
            switch (name.ToLower())
            {
                case "square":
                    return new Square();
                case "circle":
                    return new Circle();
                default:
                    break;
            }
            return null;
        }
    }
}
