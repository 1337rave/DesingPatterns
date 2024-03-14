using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesingPatterns.AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.CursorVisible = false;
            ToyFactory teddyToyFactory = new ToysFactory();
            Bear teddyBear = teddyToyFactory.GetBear();
            Cat teddyCat = teddyToyFactory.GetCat();

            teddyBear.Roar();
            teddyCat.Meow();

            ToyFactory woodenToyFactory = new WoodenToysFactory();
            Bear woodenBear = woodenToyFactory.GetBear();
            Cat woodenCat = woodenToyFactory.GetCat();

            woodenBear.Roar();
            woodenCat.Meow();
        }
    }
}