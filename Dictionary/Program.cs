using System;
using System.Collections.Generic;
using System.IO;
class Solution
{
    /// <summary>
    /// The entrypoint of the application
    /// </summary>
    /// <param name="args"></param>
    static void Main(string[] args)
    {
        int amount = int.Parse(Console.ReadLine());
        Dictionary<string, string> dict = GetDict(amount);
        LookupLoop(dict);
    }

    /// <summary>
    /// The reading loop to lookup
    /// </summary>
    /// <param name="dict">The dictionary of phone numbers</param>
    public static void LookupLoop(Dictionary<string, string> dict)
    {
        while (true)
        {
            string name = Console.ReadLine();

            if (string.IsNullOrEmpty(name))
            {
                return;
            }

            if (dict.ContainsKey(name))
            {
                Console.WriteLine(name + "=" + dict[name]);
            }
            else
            {
                Console.WriteLine("Not found");
            }
        }
    }

    /// <summary>
    /// Reads the dictionary of phone numbers input in the console
    /// </summary>
    /// <param name="amount">The amount of phone numbers to be read</param>
    /// <returns>The dictionary</returns>
    public static Dictionary<string, string> GetDict(int amount)
    {
        Dictionary<string, string> dict = new Dictionary<string, string>();
        for (int i = 0; i < amount; i++)
        {
            string[] pair = ReadPair();
            dict.Add(pair[0], pair[1]);
        }

        return dict;
    }

    /// <summary>
    /// Reads a phone number and name combo from the console
    /// </summary>
    /// <returns>The phone number and name combo as a string array</returns>
    public static string[] ReadPair()
    {
        string line = Console.ReadLine();
        string[] pair = line.Split(' ');
        return pair;
    }
}