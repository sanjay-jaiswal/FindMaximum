using System;

namespace FindMaximumUsingGenerics
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("============================== Welcome To Find Maximum Program ===========================");

            //Passing integer value in max method
            GenericToFindMax<int>.FindMax(2, 3, 4, 5);
            GenericToFindMax<float>.FindMax(44.6f, 55.6f, 66.7f, 23.3f);
            GenericToFindMax<string>.FindMax("Bridgelabz", "Sanju", "Xerox", "Delhi");
        }
    }
}
