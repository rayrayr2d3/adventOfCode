using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Fifteen.One
{
    public class Solution
    {
        public static void PartOne()
        {
            var input = GetInput().ToList()[0].ToCharArray();
            var floor = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i].Equals('(')) floor++;
                if (input[i].Equals(')')) floor--;
            }

            Console.WriteLine(floor);
        }

        public static void PartTwo()
        {
            var input = GetInput().ToList()[0].ToCharArray();
            var floor = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i].Equals('(')) floor++;
                if (input[i].Equals(')')) floor--;
                if (floor == -1)
                {
                    Console.WriteLine(i + 1);
                    break;
                }
            }
        }

        public static IEnumerable<string> GetInput()
        {
            return File.ReadLines($"..\\..\\..\\01 - One\\input.txt");
        }
    }
}
