using DesignPatterns.Patterns.Stategy.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Patterns.Stategy.Models
{
    public class CannotFly : IFly
    {
        public string StartFlying()
        {
            return "Sorry I can not fly";
        }
    }
}
