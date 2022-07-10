using Memento.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento.Memento
{
    public class Originator : ConcreteMemento
    {
        private ConcreteMemento _State { get; set; }
        public void GetState() { Console.WriteLine("Get"); }
        public ConcreteMemento Save() => _State;
        public void Restor() { Console.WriteLine("Restore"); }
        
    }
}
