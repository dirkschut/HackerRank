using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountBinaryOnes
{
    class Solution
    {
        /// <summary>
        /// The starting point of the application
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            string binaryString = ConvertIntToBinaryString(int.Parse(Console.ReadLine()));
            Console.WriteLine(CountOnes(binaryString));
        }

        /// <summary>
        /// Converts an integer into a string containing it's binary value
        /// </summary>
        /// <param name="number">The input as an integer</param>
        /// <returns>The binary value as a string</returns>
        static string ConvertIntToBinaryString(int number)
        {
            string temp = "";

            while (number > 0)
            {
                int remainder = number % 2;
                number = number / 2;
                temp += remainder;
            }

            temp.Reverse();

            return temp;
        }

        /// <summary>
        /// Counts the longest string of ones in a binary value given as a string
        /// </summary>
        /// <param name="binary">The binary value given as a string</param>
        /// <returns>The longest string of ones</returns>
        public static int CountOnes(string binary)
        {
            int longest = 0;
            int current = 0;

            foreach (char character in binary)
            {
                if (character == '1')
                {
                    current++;
                }
                else
                {
                    if (current > longest)
                    {
                        longest = current;
                    }

                    current = 0;
                }
            }

            if (current > longest)
            {
                longest = current;
            }

            return longest;
        }
    }
}
