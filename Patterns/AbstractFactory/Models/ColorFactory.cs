using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns.Patterns.AbstractFactory.Contracts;

namespace DesignPatterns.Patterns.AbstractFactory.Models
{
    public class ColorFactory : Contracts.AbstractFactory
    {
        public override IColor GetColor(string name)
        {
            switch (name.ToLower())
            {
                case "blue":
                    return new Blue();
                case "green":
                    return new Green();
                default:
                    break;
            }
            return null;
        }

        public override IShape GetShape(string name)
        {
            throw new NotImplementedException();
        }
    }
}
