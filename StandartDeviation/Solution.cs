using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StandartDeviation
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
            Console.WriteLine(string.Format("{0:0.0}", GetStandartDeviation(numbers)));
        }

        /// <summary>
        /// Calculates the standart deviation from a given list of numbers
        /// </summary>
        /// <param name="numbers">the numbers as a list of integers</param>
        /// <returns>the standart deviation as a double</returns>
        public static double GetStandartDeviation(List<int> numbers)
        {
            double mean = GetMean(numbers);
            double meanDistanceSquareSum = 0;

            foreach(int i  in numbers)
            {
                meanDistanceSquareSum += Math.Pow((i - mean), 2);
            }

            double standartDeviation = Math.Sqrt(meanDistanceSquareSum / numbers.Count);

            return standartDeviation;
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
        public static double GetMean(List<int> numbers)
        {
            int sum = 0;

            foreach (int number in numbers)
            {
                sum += number;
            }

            return sum / (double)numbers.Count;
        }
    }
}
