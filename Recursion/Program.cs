using System;

namespace Recursion
{
    class Solution
    {
        /// <summary>
        /// The entrypoint of the application.
        /// </summary>
        /// <param name="args"></param>
        public static void Main(string[] args)
        {
            int i = int.Parse(Console.ReadLine());
            Console.WriteLine(Factorial(i));
        }

        /// <summary>
        /// A very simple factorial function.
        /// </summary>
        /// <param name="i">The number you want to get the factorial of</param>
        /// <returns>The factorial of the given number.</returns>
        public static int Factorial(int i)
        {
            if (i == 0)
                return 1;

            return i * Factorial(i - 1);
        }
    }

}