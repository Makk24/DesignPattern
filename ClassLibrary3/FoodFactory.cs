using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary3
{
    public class FoodSimpleFactory
    {
        public static Food CreateFood(string str)
        {
            Food food = null;
            //switch (str)
            //{
            //    case "土豆丝":
            //        food = new Potatoes();
            //        break;
            //    case"鸡蛋":
            //        food = new Eggs();
            //        break;
            //    default:
            //        break;
            //}
            return food;
        }
    }
}
