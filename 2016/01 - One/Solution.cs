using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Sixteen.One
{
    public class Solution
    {
        public static void PartOne()
        {
            var input = GetInput().ToList()[0].Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var x = 0;
            var y = 0;

            var direction = "";

            for (int i = 0; i < input.Length; i++)
            {
                int distance = Int32.Parse(input[i].Trim().Substring(1));

                if (string.IsNullOrWhiteSpace(direction) || direction.Equals("N"))
                {
                    if (input[i][0].Equals('R'))
                    {
                        direction = "E";
                        x += distance;
                    }

                    if (input[i][0].Equals('L'))
                    {
                        direction = "W";
                        x -= distance;
                    }
                }
                else if (direction.Equals("S"))
                {
                    if (input[i][0].Equals('R'))
                    {
                        direction = "W";
                        x -= distance;
                    }

                    if (input[i][0].Equals('L'))
                    {
                        direction = "E";
                        x += distance;
                    }
                }
                else if (direction.Equals("E"))
                {
                    if (input[i][0].Equals('R'))
                    {
                        direction = "S";
                        y -= distance;
                    }

                    if (input[i][0].Equals('L'))
                    {
                        direction = "N";
                        y += distance;
                    }
                }
                else if (direction.Equals("W"))
                {
                    if (input[i][0].Equals('R'))
                    {
                        direction = "N";
                        y += distance;
                    }

                    if (input[i][0].Equals('L'))
                    {
                        direction = "S";
                        y -= distance;
                    }
                }
            }

            Console.WriteLine($"X: {x}, Y: {y}, Total: {x + y}");
        }

        public static void PartTwo()
        {
            var input = GetInput().ToList();

        }

        public static IEnumerable<string> GetInput()
        {
            return File.ReadLines($"..\\..\\..\\01 - One\\input.txt");
        }
    }
}
