using System;

namespace FindMaximumUsingGenerics
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("============================== Welcome To Find Maximum Program ===========================");
            FindMaximumValue findMax = new FindMaximumValue();
            Console.WriteLine(findMax.CompareThreeIntegers(200, 250, 450));
        }
    }
}
