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
            int x = 0, y = 0;
            var direction = "";

            for (int i = 0; i < input.Length; i++)
            {
                int distance = int.Parse(input[i].Trim()[1..]);

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

            Console.WriteLine($"X: {x}, Y: {y}, Total: {Math.Abs(x) + Math.Abs(y)} blocks.");
        }

        public static void PartTwo()
        {
            var input = GetInput().ToList()[0].Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
            List<string> visited = new List<string>(), solutions = new List<string>();
            int x = 0, y = 0;
            var direction = "";

            for (int i = 0; i < input.Length; i++)
            {
                int distance = int.Parse(input[i].Trim()[1..]);

                if (string.IsNullOrWhiteSpace(direction) || direction.Equals("N"))
                {
                    if (input[i][0].Equals('R'))
                    {
                        direction = "E";
                        for (int l = x; l < x + distance; l++)
                        {
                            if (visited.Any(_ => _.Equals($"{l}, {y}")))
                                solutions.Add($"{l}, {y}");
                            else visited.Add($"{l}, {y}");
                        }

                        x += distance;
                    }

                    if (input[i][0].Equals('L'))
                    {
                        direction = "W";
                        for (int l = x; l > x - distance; l--)
                        {
                            if (visited.Any(_ => _.Equals($"{l}, {y}")))
                                solutions.Add($"{l}, {y}");
                            else visited.Add($"{l}, {y}");
                        }

                        x -= distance;
                    }
                }
                else if (direction.Equals("S"))
                {
                    if (input[i][0].Equals('R'))
                    {
                        direction = "W";
                        for (int l = x; l > x - distance; l--)
                        {
                            if (visited.Any(_ => _.Equals($"{l}, {y}")))
                                solutions.Add($"{l}, {y}");
                            else visited.Add($"{l}, {y}");
                        }

                        x -= distance;
                    }

                    if (input[i][0].Equals('L'))
                    {
                        direction = "E";
                        for (int l = x; l < x + distance; l++)
                        {
                            if (visited.Any(_ => _.Equals($"{l}, {y}")))
                                solutions.Add($"{l}, {y}");
                            else visited.Add($"{l}, {y}");
                        }

                        x += distance;
                    }
                }
                else if (direction.Equals("E"))
                {
                    if (input[i][0].Equals('R'))
                    {
                        direction = "S";
                        for (int l = y; l > y - distance; l--)
                        {
                            if (visited.Any(_ => _.Equals($"{x}, {l}")))
                                solutions.Add($"{x}, {l}");
                            else visited.Add($"{x}, {l}");
                        }

                        y -= distance;
                    }

                    if (input[i][0].Equals('L'))
                    {
                        direction = "N";
                        for (int l = y; l < y + distance; l++)
                        {
                            if (visited.Any(_ => _.Equals($"{x}, {l}")))
                                solutions.Add($"{x}, {l}");
                            else visited.Add($"{x}, {l}");
                        }

                        y += distance;
                    }
                }
                else if (direction.Equals("W"))
                {
                    if (input[i][0].Equals('R'))
                    {
                        direction = "N";
                        for (int l = y; l < y + distance; l++)
                        {
                            if (visited.Any(_ => _.Equals($"{x}, {l}")))
                                solutions.Add($"{x}, {l}");
                            else visited.Add($"{x}, {l}");
                        }

                        y += distance;
                    }

                    if (input[i][0].Equals('L'))
                    {
                        direction = "S";
                        for (int l = y; l > y - distance; l--)
                        {
                            if (visited.Any(_ => _.Equals($"{x}, {l}")))
                                solutions.Add($"{x}, {l}");
                            else visited.Add($"{x}, {l}");
                        }

                        y -= distance;
                    }
                }
            }

            Console.WriteLine($"Location: ({solutions[0]})");
            Console.WriteLine($"Distance: {Math.Abs(int.Parse(solutions[0].Split(',')[0])) + Math.Abs(int.Parse(solutions[0].Split(',')[1]))} blocks.");
        }

        public static IEnumerable<string> GetInput()
        {
            return File.ReadLines($"..\\..\\..\\01 - One\\input.txt");
        }
    }
}
