using DesignPatterns.Patterns.Stategy.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Patterns.Stategy
{
    public abstract class Bird
    {
        public IFly FlyBehaviour { get; }
        public string Name { get; set; }

        public Bird(IFly flyBehaviour)
        {
            this.FlyBehaviour = flyBehaviour;
        }

    }
}
