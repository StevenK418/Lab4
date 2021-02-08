/*
 * Name:        Steven Kelly
 * Date:        08/02/2021
 * Exercise:    Lab4Q1
 * Description: "Write the following methods that take an array of ints as a parameter and returns
 *               1.	The largest value in the array (don’t use the built in Max property, code it yourself)
 *               2.	The smallest value in the array (don’t use the built in Min property, code it yourself)
 *               3.	True if the array is sorted in ascending order otherwise false
 *               4.	The average of every third element in the array, starting with the first element
 *               5.	The standard deviation of all the values stored in the array (check out your maths notes or Math or www.MathisFun.com"
*/
using System;

namespace Lab4Q1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        /// <summary>
        /// Finds the largest number in a given array
        /// </summary>
        /// <param name="values"></param>
        /// <returns>Returns the largest number as an Int.</returns>
        static int FindLargestValue(int[] values)
        {
            int largestValue = 0;
            foreach (int value in values)
            {
                if (value > largestValue)
                {
                    largestValue = value;
                }
            }
            return largestValue;
        }

        /// <summary>
        /// Finds the smallest number in a given array
        /// </summary>
        /// <param name="values"></param>
        /// <returns>Returns the smallest number as an Int.</returns>
        static int FindSmallestValue(int[] values)
        {
            int smallestValue = 0;
            foreach (int value in values)
            {
                if (value < smallestValue)
                {
                    smallestValue = value;
                }
            }
            return smallestValue;
        }

        /// <summary>
        /// Checks if values in a given array are in ascending order.
        /// </summary>
        /// <param name="values"></param>
        /// <returns>Returns true or false respectively if 
        /// the arry is in ascending order or not.</returns>
        static bool IsAscendingOrder(int[] values)
        {
            int count = 0;
            int latestvalue = values[0];
            bool isAscending = false;

            foreach (int value in values)
            {
                if (value > latestvalue)
                {
                    latestvalue = value;
                    count++;
                }
            }
            if (count == values.Length)
            {
                isAscending = true;
            }
            else
            {
                isAscending = false;
            }
            return isAscending;
        }

        /// <summary>
        /// Finds the average of every 3rd element in a given array 
        /// starting from the first. 
        /// </summary>
        /// <param name="values"></param>
        /// <returns>Returns the average as an int.</returns>
        static int FindAverageOfThirds(int[] values)
        {
            int sum = 0;
            int elementCounter = 0;
            for (int i = 0; i < values.Length; i+=3)
            {
                sum += values[i];
                elementCounter++;
            }
            return sum / elementCounter;
        }
        static double FindStandardDeviation(int[] values)
        {
            double sd = 0;
            foreach (var item in collection)
            {

            }
        }
    }
}
