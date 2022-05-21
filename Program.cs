using System;

namespace TestMaximum
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Test Maximum Program");
            Console.WriteLine(IntegerMax.MaxIntNumber(20,10,5));
            Console.WriteLine(IntegerMax.MaxIntNumber(5, 20, 10));
            Console.WriteLine(IntegerMax.MaxIntNumber(5,10,20));
            Console.WriteLine(FloatMax.MaxFloatNumber(5.5f,3.2f,1.2f));
            Console.WriteLine(FloatMax.MaxFloatNumber(3.2f,5.5f,1.2f));
            Console.WriteLine(FloatMax.MaxFloatNumber(3.2f,1.2f,5.5f));
        }
    }
}
