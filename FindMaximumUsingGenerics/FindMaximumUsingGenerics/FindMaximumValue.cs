using System;
using System.Collections.Generic;
using System.Text;

namespace FindMaximumUsingGenerics
{
    public class GenericToFindMax<T> where T : IComparable
    {
        /// <summary>
        ///Using params no need to specify how many 
        ///numbers of parameters you wants to pass.  
        /// </summary>
        /// <param name="variables"></param>
        /// <returns></returns>
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

        /// <summary>
        ///This will print max value
        /// </summary>
        /// <param name="maxElement"></param>
        public static void printMaxValue(T maxElement)
        {
            Console.WriteLine("Maximum Value is : " + maxElement);
        }
    }
}
