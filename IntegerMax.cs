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
            if(firstnum.CompareTo(secondnum) >  0 && firstnum.CompareTo(thirdnum) > 0)
            {
                return firstnum;
            }
            else if(secondnum.CompareTo(firstnum) > 0 && secondnum.CompareTo(thirdnum) > 0)
            {
                return secondnum;
            }
             return thirdnum;
        }
    }
}
