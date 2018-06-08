using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns.Patterns.Stategy.Contracts;
using DesignPatterns.Patterns.Stategy.Models;

namespace DesignPatterns.Patterns.Stategy
{
    public class Chicken : Bird
    {
        public Chicken():base(new CannotFly())
        {
        }
    }
}
