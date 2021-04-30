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
            Console.WriteLine(findMax.CompareThreeFloatValues(20.5f, 12.8f, 4.3f));
            Console.WriteLine(findMax.CompareThreeStrings("Apple", "Orange", "Banana"));

        }
    }
}
