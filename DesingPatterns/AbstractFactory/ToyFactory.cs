﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesingPatterns.AbstractFactory
{
    public interface ToyFactory
    {
        Bear GetBear();
        Cat GetCat();
    }
}