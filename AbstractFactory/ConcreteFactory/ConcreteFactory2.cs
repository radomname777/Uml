using AbstractFactory.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.ConcreteFactory
{
    internal class ConcreteFactory2 : Abstract.AbstractFactory
    {
        public ProductA CreateProductA()
        {
            throw new NotImplementedException();
        }

        public ProductB CreateProductB()
        {
            throw new NotImplementedException();
        }
    }
}
