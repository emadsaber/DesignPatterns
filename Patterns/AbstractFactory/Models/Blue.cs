﻿using DesignPatterns.Patterns.AbstractFactory.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Patterns.AbstractFactory.Models
{
    public class Blue : IColor
    {
        public void Fill()
        {
            Console.WriteLine("Filling with a blue color");
        }
    }
}
