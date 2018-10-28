using System;
using System.Collections.Generic;
using System.IO;
namespace reviewloop
{
    class Solution
    {
        /// <summary>
        /// A quick and dirty solution for the review loop challange
        /// </summary>
        /// <param name="args"></param>
        static void Main(String[] args)
        {
            int amount = int.Parse(Console.ReadLine());

            List<string> formattedStrings = new List<string>();

            for(int i = 0; i < amount; i++)
            {
                string tempString = Console.ReadLine();
                string odd = "";
                string even = "";

                for(int j = 0; j <  tempString.Length; j++)
                {
                    if(j % 2 == 0)
                    {
                        even += tempString[j];
                    }
                    else
                    {
                        odd += tempString[j];
                    }
                }

                formattedStrings.Add(even + " " + odd);
            }

            foreach(string s in formattedStrings)
            {
                Console.WriteLine(s);
            }

        }
    }
}
