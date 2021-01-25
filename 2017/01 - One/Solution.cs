using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Seventeen.One
{
    public class Solution
    {
        public static void PartOne()
        {
            var input = GetInput().ToList()[0].ToString().ToCharArray().Select(_ => int.Parse(_.ToString())).ToList();
            var traversed = new List<int>();
            var sum = 0;

            for (var i = 0; i < input.Count(); i++)
            {
                if (!traversed.Any()) traversed.Add(input[i]);
                else
                {
                    if (traversed[i - 1] == input[i]) sum += input[i];
                    traversed.Add(input[i]);
                }
            }

            if (traversed[traversed.Count - 1] == traversed[0]) sum += traversed[traversed.Count - 1];

            Console.WriteLine(sum);
        }

        public static void PartTwo()
        {
            var input = GetInput().ToList()[0].ToString().ToCharArray().Select(_ => int.Parse(_.ToString())).ToList();
            var count = input.Count();
            var sum = 0;

            for (var i = 0; i < count/2; i++)
                if (input[i] == input[(count / 2) + i]) sum += 2 * input[i];

            Console.WriteLine(sum);
        }

        public static IEnumerable<string> GetInput()
        {
            return File.ReadLines($"..\\..\\..\\01 - One\\input.txt");
        }
    }
}
