using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace AdventOfCode
{
    public abstract class Day
    {
        public IEnumerable<string> GetInput(int year, int day)
        {
            return File.ReadAllLines("../Input/Y" + year.ToString() + "/Day" + day.ToString() + ".txt").AsEnumerable();
        }
        public abstract int SolvePart1();
        public abstract int SolvePart2();
    }
}

