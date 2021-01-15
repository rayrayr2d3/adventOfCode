using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Fifteen.Two
{
    public class Solution
    {
        public static void PartOne()
        {
            var input = GetInput().ToList();
            var total = 0;

            for (int i = 0; i < input.Count; i++)
            {
                var values = input[i].Split('x');
                var length = Int32.Parse(values[0]);
                var width = Int32.Parse(values[1]);
                var height = Int32.Parse(values[2]);

                var sideOne = length * width;
                var sideTwo = width * height;
                var sideThree = height * length;

                var smallestSide = 0;
                if (sideOne <= sideTwo && sideOne <= sideThree) smallestSide = sideOne;
                else if (sideTwo <= sideOne && sideTwo <= sideThree) smallestSide = sideTwo;
                else if (sideThree <= sideOne && sideThree <= sideTwo) smallestSide = sideThree;

                total = total + 2 * sideOne + 2 * sideTwo + 2 * sideThree + smallestSide;
            }

            Console.WriteLine(total);
        }

        public static void PartTwo()
        {
            var input = GetInput().ToList();
            var total = 0;

            for (int i = 0; i < input.Count; i++)
            {
                var values = input[i].Split('x');
                var length = Int32.Parse(values[0]);
                var width = Int32.Parse(values[1]);
                var height = Int32.Parse(values[2]);

                var periOne = 2 * length + 2 * width;
                var periTwo = 2 * width + 2 * height;
                var periThree = 2 * height + 2 * length;

                var smallestPeri = 0;
                if (periOne <= periTwo && periOne <= periThree) smallestPeri = periOne;
                else if (periTwo <= periOne && periTwo <= periThree) smallestPeri = periTwo;
                else if (periThree <= periOne && periThree <= periTwo) smallestPeri = periThree;

                var volume = length * width * height;

                total += volume + smallestPeri;
            }

            Console.WriteLine(total);
        }

        public static IEnumerable<string> GetInput()
        {
            return File.ReadLines($"..\\..\\..\\02 - Two\\input.txt");
        }
    }
}
