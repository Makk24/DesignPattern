using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary3
{
    public class Eggs:Food
    {
        public override void Print()
        {
            Console.WriteLine("炒鸡蛋一份");
        }
    }
    public class Potatoes : Food
    {
        public override void Print()
        {
            Console.WriteLine("土豆丝一份");
        }
    }
}
