using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeightedAvarage
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
            List<int> weights = GetNumbers(Console.ReadLine());

            Console.WriteLine(String.Format("{0:0.0}", GetWeightedAvarage(numbers, weights)));
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
        /// Returns the weighted total of a given list of integers and weights
        /// </summary>
        /// <param name="numbers">the numbers</param>
        /// <param name="weights">the weights</param>
        /// <returns>the weighted avarage</returns>
        public static double GetWeightedAvarage(List<int> numbers, List<int> weights)
        {
            int weighterNumbersTotal = 0;
            int weightsTotal = 0;

            for(int i = 0; i < numbers.Count; i++)
            {
                weighterNumbersTotal += numbers[i] * weights[i];
                weightsTotal += weights[i];
            }

            return weighterNumbersTotal / (double)weightsTotal;
        }
    }
}
