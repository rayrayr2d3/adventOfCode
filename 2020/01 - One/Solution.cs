using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Twenty.One
{
    public class Solution
    {
        public static void PartOne()
        {
            var input = GetInput().ToList();

            for (int i = 0; i < input.Count; i++)
                for (int j = 0; j < input.Count; j++)
                    if (int.Parse(input[i]) + int.Parse(input[j]) == 2020)
                        Console.WriteLine(int.Parse(input[i]) * int.Parse(input[j]));
        }

        public static void PartTwo()
        {
            var input = GetInput().ToList();

            for (int i = 0; i < input.Count; i++)
                for (int j = 0; j < input.Count; j++)
                    for (int k = 0; k < input.Count; k++)
                        if (int.Parse(input[i]) + int.Parse(input[j]) + int.Parse(input[k]) == 2020)
                            Console.WriteLine(int.Parse(input[i]) * int.Parse(input[j]) * int.Parse(input[k]));
        }

        public static IEnumerable<string> GetInput()
        {
            return File.ReadLines($"..\\..\\..\\01 - One\\input.txt");
        }
    }
}
