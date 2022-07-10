using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Memento.Interface
{
    public interface ConcreteMemento
    {

        private ConcreteMemento _State
        {

            set { _State = value; }
        }
        public void GetState();

    }
}
