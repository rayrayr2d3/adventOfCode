﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Seventeen.Three
{
    public class Solution
    {
        public static void PartOne()
        {
            var input = GetInput().ToList();

            for (int i = 0; i < input.Count; i++)
            {
                Console.WriteLine(input);
            }
        }

        public static void PartTwo()
        {
            var input = GetInput().ToList();

        }

        public static IEnumerable<string> GetInput()
        {
            return File.ReadLines($"..\\..\\..\\03 - Three\\input.txt");
        }
    }
}
