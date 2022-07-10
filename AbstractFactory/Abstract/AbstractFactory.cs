using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Abstract
{
    public interface AbstractFactory
    {
        public ProductA CreateProductA();
        public ProductB CreateProductB();
    }
}
