using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using ClassLibrary1;

namespace ConsoleTest
{
    class Program
    {
        public static void Main(String[] args)
        {
            //Originator originator = new Originator();
            //originator.SetState("状态1");
            //Console.WriteLine("初始状态:" + originator.GetState());
            //Caretaker caretaker = new Caretaker();
            //caretaker.SetMemento(originator.CreateMemento());
            //originator.SetState("状态2");
            //Console.WriteLine("改变后状态:" + originator.GetState());
            //originator.RestoreMemento(caretaker.GetMemento());
            //Console.WriteLine("恢复后状态:" + originator.GetState());
            //Console.ReadKey();
            Player role = new Player(100, 100);
            Taker taker = new Taker();
            Console.WriteLine("初始状态：");
            role.showstate();
            //保存备忘录
            taker.MementoDic.Add(DateTime.Now.ToString(),role.creatememento());
            role.setage(50);
            role.setrand(30);
            Console.WriteLine("战斗后状态：");
            role.showstate();
            //再次保存备忘录
            Thread.Sleep(1000);
            taker.MementoDic.Add(DateTime.Now.ToString(), role.creatememento());
            ////恢复备忘录状态
            //role.setmemento(taker.getmemento());
            //Console.WriteLine("恢复备忘录状态：");
            //role.showstate();
            role.setage(0);
            role.setrand(60);
            Console.WriteLine("再次战斗后状态：");
            role.showstate();
            var keyCollection = taker.MementoDic.Keys;
            RoleMemento memento;
            int i = 1;
            foreach (var key in keyCollection)
            {
                if (taker.MementoDic.TryGetValue(key, out memento))
                {
                    Console.WriteLine("备份" + i + "："+"\n"+"备份时间："+key);
                    role.setmemento(memento);
                    role.showstate();
                }
                i++;
            }
            Console.ReadKey();
        }
    }
}
