using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication10
{
    public class MainClass
    {
        private static void Shuffle()
        {
            var random = new Random();
            var result = new List<string>();
            string[] cardType = { "红桃", "黑桃", "方块", "梅花" };
            string[] cardValue = { "A", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K" };
            foreach (string type in cardType)
            {
                var list = cardValue.Select(value => string.Format("{0}{1}", type, value));
                result.AddRange(list);
            }
            result = (from c in result orderby random.Next(0, 51) descending select c).ToList();
            result.ForEach(str => Console.Write("{0},", str));
        }

        public static void Main(string[] args)
        {
            Shuffle();
            Console.ReadKey();
        }
    }
}
