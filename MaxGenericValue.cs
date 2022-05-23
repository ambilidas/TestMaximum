using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestMaximum
{
    public class MaxGenericValue<T> where T : IComparable
    {
        public T[] Value;
        public MaxGenericValue(T[] Value)
        {
            this.Value = Value;
        }
        public T[] Sort(T[] Values)
        {
            Array.Sort(Values);
            return Values;
        }
        public T findMax(T[] Value)
        {
            var sortedValues = Sort(Value);
            return sortedValues[^1];
        }
        
    }
}
