﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesingPatterns.FactoryMethod
{
    public class ConcreteProductA : Product
    {
        public string Operation()
        {
            return "Результат операції ConcreteProductA";
        }
    }
}