using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
   public class Player
    {
        private int age;
        private int rand;

        public Player( int age,int rand)
        {
            this.age=age;
            this.rand=rand;
        }

        public Player()
        {
        }

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
        //保存状态
        public RoleMemento creatememento()
        {
            RoleMemento memento = new RoleMemento();
            memento.setage(age);
            memento.setrand(rand);
            return memento;
        }
        //恢复状态
        public void setmemento(RoleMemento memento)
        {
            this.age = memento.getage();
            this.rand = memento.getrand();
        }
        //显示状态
        public void showstate()
        {
            Console.WriteLine("生命值：" + this.age + "\n等级：" + this.rand);
        }
    }
}
