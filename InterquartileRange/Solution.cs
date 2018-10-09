using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterquartileRange
{
    public class Solution
    {
        /// <summary>
        /// The start point of the program
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int amount = int.Parse(Console.ReadLine());
            List<int> numbers = GetNumbers(Console.ReadLine());
            List<int> frequencies = GetNumbers(Console.ReadLine());

            List<int> actualNumbers = CompleteList(numbers, frequencies);

            Console.WriteLine(string.Format("{0:0.0}", GetQuartileRange(actualNumbers)));
        }

        /// <summary>
        /// Makes a complete list of integers from a given list of numbers and a given list of frequencies
        /// </summary>
        /// <param name="numbers">the numbers to be added</param>
        /// <param name="amounts">the frequency of which each number should be present</param>
        /// <returns>the completed list</returns>
        public static List<int> CompleteList(List<int> numbers, List<int> amounts)
        {
            List<int> actualNumbers = new List<int>();
            for (int i = 0; i < numbers.Count; i++)
            {
                for (int j = 0; j < amounts[i]; j++)
                {
                    actualNumbers.Add(numbers[i]);
                }
            }
            return actualNumbers;
        }

        /// <summary>
        /// Gets the quartile range of a given list of integers
        /// </summary>
        /// <param name="numbers">The list of integers</param>
        /// <returns>the guartile range</returns>
        public static double GetQuartileRange(List<int> numbers)
        {
            List<double> quartiles = GetQuartiles(numbers);

            return quartiles[2] - quartiles[0];
        }

        /// <summary>
        /// Gets the quartiles from a given list of integers
        /// </summary>
        /// <param name="numbers">the list of integers</param>
        /// <returns>the quartiles</returns>
        public static List<double> GetQuartiles(List<int> numbers)
        {
            double q2 = GetMedian(numbers);

            List<int> below = new List<int>();
            List<int> above = new List<int>();
            //foreach (int i in numbers)
            //{
            //    if (i < q2)
            //    {
            //        below.Add(i);
            //    }
            //    else if (i > q2)
            //    {
            //        above.Add(i);
            //    }
            //}


            for(int i = 0; i < numbers.Count; i++)
            {
                if(i < numbers.Count / 2)
                {
                    below.Add(numbers[i]);
                }
                else if(i > numbers.Count / 2)
                {
                    above.Add(numbers[i]);
                }
            }

            double q1 = GetMedian(below);
            double q3 = GetMedian(above);

            return new List<double> { q1, q2, q3 };
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
        /// Gets the median of a list of integers
        /// </summary>
        /// <param name="numbers">the given list of integers</param>
        /// <returns>the median</returns>
        public static double GetMedian(List<int> numbers)
        {
            numbers.Sort();

            if (numbers.Count % 2 == 1) return numbers[(numbers.Count - 1) / 2];

            int below = numbers[numbers.Count / 2 - 1];
            int above = numbers[numbers.Count / 2];

            return (below + above) / 2d;
        }
    }
}
