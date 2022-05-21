using System;

namespace TestMaximum
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Test Maximum Program");
            Console.WriteLine(MaxValue.MaxIntNumber(20,10,5));
            Console.WriteLine(MaxValue.MaxIntNumber(5, 20, 10));
            Console.WriteLine(MaxValue.MaxIntNumber(5,10,20));
            Console.WriteLine(FloatMax.MaxFloatNumber(5.5f,3.2f,1.2f));
            Console.WriteLine(FloatMax.MaxFloatNumber(3.2f,5.5f,1.2f));
            Console.WriteLine(FloatMax.MaxFloatNumber(3.2f,1.2f,5.5f));
            Console.WriteLine(StringMax.MaxStringValue("Bridgelabzzz","Bridgelabzz","Bridgelabz"));
            Console.WriteLine(StringMax.MaxStringValue("Bridgelabzz", "Bridgelabzzz", "Bridgelabz"));
            Console.WriteLine(StringMax.MaxStringValue("Bridgelabz", "Bridgelabzz", "Bridgelabzzz"));
        }
    }
}
