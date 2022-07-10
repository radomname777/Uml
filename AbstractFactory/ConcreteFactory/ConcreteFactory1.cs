using AbstractFactory.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.ConcreteFactory
{
    public class ConcreteFactory1 : Abstract.AbstractFactory
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
