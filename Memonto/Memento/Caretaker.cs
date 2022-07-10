using Memento.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento.Memento
{
    public class Caretaker : Interface.ConcreteMemento
    {
        private Originator? _Originator { get;set; }
        private Originator[]? _History { get; set; }
        void ConcreteMemento.GetState()
        {
            Console.WriteLine("State");
        }
        public void Undo() { Console.WriteLine("Undo"); }
    }
}
