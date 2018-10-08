using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quartiles
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
            List<double> Quartiles = GetQuartiles(numbers);
            Console.WriteLine(Quartiles[0]);
            Console.WriteLine(Quartiles[1]);
            Console.WriteLine(Quartiles[2]);
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
            foreach(int i in numbers)
            {
                if(i < q2)
                {
                    below.Add(i);
                }
                else if(i > q2)
                {
                    above.Add(i);
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

            if (numbers.Count % 2 == 1) return numbers[numbers.Count / 2];

            int below = numbers[numbers.Count / 2 - 1];
            int above = numbers[numbers.Count / 2];

            return (below + above) / 2d;
        }
    }
}
