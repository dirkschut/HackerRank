using System;
using System.Collections.Generic;
using System.IO;
namespace MeanMedianAvarage
{
    public class Solution
    {
        /// <summary>
        /// The startpoint of the program.
        /// </summary>
        /// <param name="args"></param>
        static void Main(String[] args)
        {

            int amount = int.Parse(Console.ReadLine());
            List<int> numbers = GetNumbers(Console.ReadLine());

            Console.WriteLine(GetMean(numbers));
            Console.WriteLine(GetMedian(numbers));
            Console.WriteLine(GetMode(numbers));

        }

        /// <summary>
        /// Converts a string into a list of numbers
        /// </summary>
        /// <param name="text">the string containing the numbers</param>
        /// <returns>the numbers in a list</returns>
        public static List<int> GetNumbers(string text)
        {
            string[] splitStrings = text.Split(null);
            List<int> numbers = new List<int>();
            foreach (string tempString in splitStrings)
            {
                numbers.Add(int.Parse(tempString.Trim()));
            }
            return numbers;
        }

        /// <summary>
        /// Gets the mean from a given list of integers.
        /// </summary>
        /// <param name="numbers">integers in a list</param>
        /// <returns>the mean as a float</returns>
        public static float GetMean(List<int> numbers)
        {
            int sum = 0;

            foreach (int number in numbers)
            {
                sum += number;
            }

            return sum / (float)numbers.Count;
        }

        /// <summary>
        /// Gets the median of a list of integers
        /// </summary>
        /// <param name="numbers">the given list of integers</param>
        /// <returns>the median</returns>
        public static float GetMedian(List<int> numbers)
        {
            numbers.Sort();

            if(numbers.Count % 2 == 1) return numbers[numbers.Count / 2];

            int below = numbers[numbers.Count / 2 - 1];
            int above = numbers[numbers.Count / 2];

            return (below + above) / 2f;
        }

        /// <summary>
        /// Gets the mode of a given list of integers
        /// </summary>
        /// <param name="numbers">The given list of integers</param>
        /// <returns>The mode as an int</returns>
        public static int GetMode(List<int> numbers)
        {
            numbers.Sort();

            int currentNumber = 0;
            int count = 0;

            int largestCount = 0;
            int largestCountNumber = 0;

            foreach(int number in numbers)
            {
                if(number == currentNumber)
                {
                    count++;
                }
                else
                {
                    if(count > largestCount)
                    {
                        largestCount = count;
                        count = 1;
                        largestCountNumber = currentNumber;
                        currentNumber = number;
                    }
                    else
                    {
                        count = 1;
                        currentNumber = number;
                    }
                }
            }

            return largestCountNumber;
        }
    }
}
