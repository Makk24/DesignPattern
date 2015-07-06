using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
   public class Taker
    {
        private RoleMemento memento;
       //private Dictionary<string, RoleMemento> mementodic;
        public Dictionary<string, RoleMemento> MementoDic { get; set; }
        public Taker()
        {
           MementoDic = new Dictionary<string, RoleMemento>();
        }
        public RoleMemento getmemento()
        {
            return memento;
        }

        public void setmemento(RoleMemento memento)
        {
            this.memento = memento;
        }
    }
}
