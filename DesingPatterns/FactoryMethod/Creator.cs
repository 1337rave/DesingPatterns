using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesingPatterns.FactoryMethod
{
    public abstract class Creator
    {
        public abstract Product FactoryMethod();

        public string SomeOperation()
        {
            var product = FactoryMethod();
            var result = "Creator: Той самий код створювача працює з " + product.Operation();

            return result;
        }
    }
}
