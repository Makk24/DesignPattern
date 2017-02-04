using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Class1
    {
    }
    public abstract class buildertest
    {
        public abstract void builderpart1();
        public abstract void builderpart2();
        public abstract product getproduct();
    }

    public class product
    {
        private List<string> _part = new List<string>();

        public void add(string part)
        {
            _part.Add(part);
        }

        public void show()
        {
            Console.WriteLine("product parts");
            foreach (var part in _part)
            {
                Console.WriteLine(part);
            }
        }
    }

    public class createbuilder1 : buildertest
    {
        private product _product = new product();

        public override void builderpart1()
        {
            _product.add("part1");
        }
        public override void builderpart2()
        {
            _product.add("part2");
        }
        public override product getproduct()
        {
            return _product;
        }
    }

    public class director
    {
        public void construct(buildertest builder)
        {
            builder.builderpart1();
            builder.builderpart2();
        }
    }
}
