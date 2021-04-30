using System;
using System.Collections.Generic;
using System.Text;

namespace FindMaximumUsingGenerics
{
    public class GenericToFindMax<T> where T : IComparable
    {
        public static T FindMax(params T[] variables)
        {
            T maxVal = variables[0];
            foreach (T element in variables)
            {
                if (element.CompareTo(maxVal) > 0)
                {
                    maxVal = element;
                }
            }
            printMaxValue(maxVal);
            return maxVal;
        }
        public static void printMaxValue(T maxElement)
        {
            Console.WriteLine("Maximum Value is : " + maxElement);
        }
    }
}
