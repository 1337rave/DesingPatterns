﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesingPatterns.Prototype
{
    public interface Prototype<T>
    {
        T Clone();
    }
}
