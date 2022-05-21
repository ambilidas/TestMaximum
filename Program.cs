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
        }
    }
}
