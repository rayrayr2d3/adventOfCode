using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Eighteen.One
{
    public class Solution
    {
        public static void PartOne()
        {
            var input = GetInput().ToList().Select(_ => int.Parse(_)).ToList();
            var result = 0;

            for (var i = 0; i < input.Count(); i++)
                result += input[i];

            Console.WriteLine(result);
        }

        public static void PartTwo()
        {
            var input = GetInput().ToList().Select(_ => int.Parse(_)).ToList();
            input.ForEach(_ => Console.WriteLine(_));
        }

        public static IEnumerable<string> GetInput()
        {
            return File.ReadLines($"..\\..\\..\\01 - One\\input.txt");
        }
    }
}
