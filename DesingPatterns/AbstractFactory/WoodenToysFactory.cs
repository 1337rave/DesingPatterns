using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesingPatterns.AbstractFactory
{
    public class WoodenToysFactory : ToyFactory
    {
        public Bear GetBear()
        {
            return new WoodenBear();
        }

        public Cat GetCat()
        {
            return new WoodenCat();
        }
    }
}