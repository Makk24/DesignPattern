using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary3
{
   public class EggsFactory:Creator
    {
       public override Food CreateFoodFactory()
       {
           return new Eggs();
       }
    }
   public class PotatoesFactory : Creator
   {
       public override Food CreateFoodFactory()
       {
           return new Potatoes();
       }
   }
}
