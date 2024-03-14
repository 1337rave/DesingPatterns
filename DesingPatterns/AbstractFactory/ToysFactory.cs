using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesingPatterns.AbstractFactory
{
    public class ToysFactory : ToyFactory
    {
        public Bear GetBear()
        {
            return new TeddyBear();
        }

        public Cat GetCat()
        {
            return new TeddyCat();
        }
    }
}