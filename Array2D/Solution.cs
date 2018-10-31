using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array2D
{
    public class Solution
    {
        /// <summary>
        /// The start point of the application
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int[,] numberArray = Get2DArray();
            Console.WriteLine(GetMaxHValue(numberArray));
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
        /// Reads a 2d array of integers from the console
        /// </summary>
        /// <returns>The 2d array</returns>
        public static int[,] Get2DArray()
        {
            int[,] numberArray = new int[6, 6];
            for (int i = 0; i < 6; i++)
            {
                List<int> numberList = GetNumbers(Console.ReadLine());
                for (int j = 0; j < 6; j++)
                {
                    numberArray[i, j] = numberList[j];
                }
            }

            return numberArray;
        }

        /// <summary>
        /// Calculates the maximum H value of a given 2d number array
        /// </summary>
        /// <param name="numberArray">The 2d number array</param>
        /// <returns>The maximum H value</returns>
        public static int GetMaxHValue(int[,] numberArray)
        {
            int maxValue = int.MinValue;

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    int value = 0;
                    value += numberArray[i, j];
                    value += numberArray[i, j + 1];
                    value += numberArray[i, j + 2];
                    value += numberArray[i + 1, j + 1];
                    value += numberArray[i + 2, j];
                    value += numberArray[i + 2, j + 1];
                    value += numberArray[i + 2, j + 2];

                    if (value >= maxValue)
                        maxValue = value;
                }
            }

            return maxValue;
        }
    }
}
