using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesingPatterns.Builder
{
    public class ConcreteBuilder : IBuilder
    {
        private Product _product = new Product();

        public void BuildPartA()
        {
            _product.Add("Part A");
        }

        public void BuildPartB()
        {
            _product.Add("Part B");
        }

        public void BuildPartC()
        {
            _product.Add("Part C");
        }

        public Product GetResult()
        {
            return _product;
        }
    }
}