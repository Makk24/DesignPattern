using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class RoleMemento
    {
        private int age;
        private int rand;

        public int getage()
        {
            return age;
        }

        public void setage(int age)
        {
            this.age = age;
        }

        public int getrand()
        {
            return rand;
        }

        public void setrand(int rand)
        {
            this.rand = rand;
        }
    }
}
