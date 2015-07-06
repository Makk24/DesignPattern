using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Memento
    {
        private String _state = "";
        public Memento(String state)
        {
            this._state = state;
        }
        public String GetState()
        {
            return _state;
        }
        public void SetState(String state)
        {
            this._state = state;
        }
    }
}
