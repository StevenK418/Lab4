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

        static int[] testArray1 = new int[9] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        static int[] testArray2 = new int[9] { 9, 8, 7, 6, 5, 4, 3, 2, 1 };
        static int[] testArray3 = new int[9] { 5, 2, 8, 2, 10, 9, 2, 5, 6 };
        static int[] testArray4 = new int[9] { 500, 210, 456, 32, 18, 725, -1, 62, 100000 };

        static void Main(string[] args)
        {
            /*Console.WriteLine("-------------------------------Largest Values-----------------------------------");
            Console.WriteLine("The largest value in array testArray{0} is {1}", 1, FindLargestValue(testArray1));
            Console.WriteLine("The largest value in array testArray{0} is {1}", 2, FindLargestValue(testArray2));
            Console.WriteLine("The largest value in array testArray{0} is {1}", 3, FindLargestValue(testArray3));
            Console.WriteLine("The largest value in array testArray{0} is {1}", 4, FindLargestValue(testArray4));

            Console.WriteLine();

            Console.WriteLine("-------------------------------Smallest Values-----------------------------------");
            Console.WriteLine("The smallest value in array testArray{0} is {1}", 1, FindSmallestValue(testArray1));
            Console.WriteLine("The smallest value in array testArray{0} is {1}", 2, FindSmallestValue(testArray2));
            Console.WriteLine("The smallest value in array testArray{0} is {1}", 3, FindSmallestValue(testArray3));
            Console.WriteLine("The smallest value in array testArray{0} is {1}", 4, FindSmallestValue(testArray4));

            Console.WriteLine();

            Console.WriteLine("-------------------------------Average Values-----------------------------------");
            Console.WriteLine("The average of each 3rd value in array testArray{0} is {1}", 1, FindAverageOfThirds(testArray1));
            Console.WriteLine("The average of each 3rd value in array testArray{0} is {1}", 2, FindAverageOfThirds(testArray2));
            Console.WriteLine("The average of each 3rd value in array testArray{0} is {1}", 3, FindAverageOfThirds(testArray3));
            Console.WriteLine("The average of each 3rd value in array testArray{0} is {1}", 4, FindAverageOfThirds(testArray4));

            Console.WriteLine();

            Console.WriteLine("-----------------------------Is Ascending order---------------------------------");
            Console.WriteLine("The average of each 3rd value in array testArray{0} is {1}", 1, IsAscendingOrder(testArray1));*/
        }
    


        /// <summary>
        /// Finds the largest number in a given array
        /// </summary>
        /// <param name="values"></param>
        /// <returns>Returns the largest number as an Int.</returns>
        static int FindLargestValue(int[] values)
        {
            int largestValue = values[0];
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
            int smallestValue = values[0];
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
            double sum = 0;
            double mean = 0;
            double standardDeviation = 0;
            foreach (int value in values)
            {
                sum += value;
            }
           
            mean = sum / values.Length;
            //standardDeviation = Math.Sqrt(sum * Math.Pow(, 2) / values.Length);
            return standardDeviation;
        }
    }
}
