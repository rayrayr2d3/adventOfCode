using System;

namespace Seventeen
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Solutions to Advent of Code 2017.");
            Console.WriteLine("What day?: ");
            var day = Console.ReadLine();
            Console.WriteLine("Part one (1) or part two (2)?: ");
            var part = Console.ReadLine();

            switch (day)
            {
                case "1":
                    if (part.Equals("1")) One.Solution.PartOne();
                    if (part.Equals("2")) One.Solution.PartTwo();
                    break;
                case "2":
                    if (part.Equals("1")) Two.Solution.PartOne();
                    if (part.Equals("2")) Two.Solution.PartTwo();
                    break;
                    //case "3":
                    //    if (part.Equals("1")) Three.Solution.PartOne();
                    //    if (part.Equals("2")) Three.Solution.PartTwo();
                    //    break;
                    //case "15":
                    //    if (part.Equals("1")) Fifteen.Solution.PartOne();
                    //    if (part.Equals("2")) Fifteen.Solution.PartTwo();
                    //    break;
                    //case "16":
                    //    if (part.Equals("1")) Sixteen.Solution.PartOne();
                    //    if (part.Equals("2")) Sixteen.Solution.PartTwo();
                    //    break;
                    //case "17":
                    //    if (part.Equals("1")) Seventeen.Solution.PartOne();
                    //    if (part.Equals("2")) Seventeen.Solution.PartTwo();
                    //    break;
            }

        }
    }
}
