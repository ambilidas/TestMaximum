using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestMaximum
{
    public class MaxValue
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
    public class FloatMax
    {
        public static float MaxFloatNumber(float firstnum, float secondnum, float thirdnum)
        {
            if (firstnum.CompareTo(secondnum) > 0 && firstnum.CompareTo(thirdnum) > 0 || firstnum.CompareTo(secondnum) >= 0 && firstnum.CompareTo(thirdnum) > 0 || firstnum.CompareTo(secondnum) > 0 && firstnum.CompareTo(thirdnum) >= 0)
            {
                return firstnum;
            }
            if (secondnum.CompareTo(firstnum) > 0 && secondnum.CompareTo(thirdnum) > 0 || secondnum.CompareTo(firstnum) >= 0 && secondnum.CompareTo(thirdnum) > 0 || secondnum.CompareTo(firstnum) > 0 && secondnum.CompareTo(thirdnum) >= 0)
            {
                return secondnum;
            }
            if (thirdnum.CompareTo(firstnum) > 0 && thirdnum.CompareTo(secondnum) > 0 || thirdnum.CompareTo(firstnum) >= 0 && thirdnum.CompareTo(secondnum) > 0 || thirdnum.CompareTo(firstnum) > 0 && thirdnum.CompareTo(secondnum) >= 0)
            {
                return thirdnum;
            }

            return firstnum;
        }
    }
    public class StringMax
    {
        public static string MaxStringValue(string first,string second,string third)
        {
            if (first.CompareTo(second) > 0 && first.CompareTo(third) > 0 || first.CompareTo(second) >= 0 && first.CompareTo(third) > 0 || first.CompareTo(second) > 0 && first.CompareTo(third) >= 0)
            {
                return first;
            }
            if (second.CompareTo(first) > 0 && second.CompareTo(third) > 0 || second.CompareTo(first) >= 0 && second.CompareTo(third) > 0 || second.CompareTo(first) > 0 && second.CompareTo(third) >= 0)
            {
                return second;
            }
            if (third.CompareTo(first) > 0 && third.CompareTo(second) > 0 || third.CompareTo(first) >= 0 && third.CompareTo(second) > 0 || third.CompareTo(first) > 0 && third.CompareTo(second) >= 0)
            {
                return third;
            }

            return first;
        }
    }
   
}
