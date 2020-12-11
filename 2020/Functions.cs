using System.Collections.Generic;
using System.IO;

namespace Twenty
{
    public interface IFunctions 
    {
        IEnumerable<string> GetInput(string folder);
    }

    public class Functions
    {
        public static IEnumerable<string> GetInput(string folder)
        {
            return File.ReadLines($"..\\..\\..\\{folder}\\input.txt");
        }
    }
}
