using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesingPatterns.Prototype
{
    public class ConcretePrototype : Prototype<ConcretePrototype>
    {
        public int Property1 { get; set; }
        public string Property2 { get; set; }

        public ConcretePrototype Clone()
        {
            return (ConcretePrototype)this.MemberwiseClone();
        }
    }
}
