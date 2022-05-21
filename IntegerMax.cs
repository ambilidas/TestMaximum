using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestMaximum
{
    internal class IntegerMax
    {
        public static int MaxIntNumber(int firstnum,int secondnum,int thirdnum)
        {
            if(firstnum.CompareTo(secondnum) >  0 && firstnum.CompareTo(thirdnum) > 0 || firstnum.CompareTo(secondnum) >= 0 && firstnum.CompareTo(thirdnum) > 0 || firstnum.CompareTo(secondnum) > 0 && firstnum.CompareTo(thirdnum) >= 0)
            {
                return firstnum;
            }
            if(secondnum.CompareTo(firstnum) > 0 && secondnum.CompareTo(thirdnum) > 0 || secondnum.CompareTo(firstnum) >= 0 && secondnum.CompareTo(thirdnum) > 0 || secondnum.CompareTo(firstnum) > 0 && secondnum.CompareTo(thirdnum) >= 0)
            {
                return secondnum;
            }
            if(thirdnum.CompareTo(firstnum) > 0 && thirdnum.CompareTo(secondnum) > 0 || thirdnum.CompareTo(firstnum) >= 0 && thirdnum.CompareTo(secondnum) > 0 || thirdnum.CompareTo(firstnum) > 0 && thirdnum.CompareTo(secondnum) >= 0)
            {
                return thirdnum;
            }
         
             return firstnum;
        }
    }
}
