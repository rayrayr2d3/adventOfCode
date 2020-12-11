using System;

namespace Twenty
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Solutions to Advent of Code 2020.");
            Console.WriteLine("What day?: ");
            var folder = Console.ReadLine();
            Console.WriteLine("Part one (1) or part two (2)?: ");
            var part = Console.ReadLine();

            switch (folder)
            {
                case "One":
                    if (part.Equals("1")) One.Solution.PartOne();
                    if (part.Equals("2")) One.Solution.PartTwo();
                    break;
                case "Two":
                    if (part.Equals("1")) Two.Solution.PartOne();
                    if (part.Equals("2")) Two.Solution.PartTwo();
                    break;
                case "Three":
                    if (part.Equals("1")) Three.Solution.PartOne();
                    if (part.Equals("2")) Three.Solution.PartTwo();
                    break;
            }
        }
    }
}
