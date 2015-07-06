using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Caretaker
    {
        private Memento _memento;
        public Memento GetMemento()
        {
            return _memento;
        }
        public void SetMemento(Memento memento)
        {
            this._memento = memento;
        }
    }
}
