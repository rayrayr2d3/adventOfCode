using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Twenty.Two
{
    public class Solution
    {
        public static void PartOne()
        {
            var input = GetInput().ToList();

            var count = 0;

            for (int i = 0; i < input.Count; i++)
            {
                var vals = input[i].Split(" ");
                var bounds = vals[0].Split("-");
                var lowerBound = int.Parse(bounds[0]);
                var higherBound = int.Parse(bounds[1]);
                var letter = vals[1].ToCharArray()[0];
                var password = vals[2].ToCharArray();

                var val = 0;

                for (int j = 0; j < password.Length; j++)
                    if (letter.Equals(password[j])) val++;

                if (val >= lowerBound && val <= higherBound) count++;
            }

            Console.WriteLine(count);
        }

        public static void PartTwo()
        {
            var input = GetInput().ToList();

            var count = 0;

            for (int i = 0; i < input.Count; i++)
            {
                var vals = input[i].Split(" ");
                var bounds = vals[0].Split("-");
                var firstPosition = int.Parse(bounds[0]) - 1;
                var secondPosition = int.Parse(bounds[1]) - 1;
                var letter = vals[1].ToCharArray()[0];
                var password = vals[2].ToCharArray();

                if (password[firstPosition] == letter || password[secondPosition] == letter)
                {
                    if (password[firstPosition] != letter && password[secondPosition] == letter)
                        count++;

                    if (password[firstPosition] == letter && password[secondPosition] != letter)
                        count++;
                }
            }

            Console.WriteLine(count);
        }

        // 813 too high

        public static IEnumerable<string> GetInput()
        {
            return File.ReadLines($"..\\..\\..\\2 - Two\\input.txt");
        }
    }
}
