using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace AdventOfCode.Y2021 {
    public abstract class Day2021 {
        public IEnumerable<string> GetInput(int day) {
            return File.ReadAllLines("../Input/Day" + day.ToString() + ".txt").AsEnumerable();
        }
        public abstract int SolvePart1();
        public abstract int SolvePart2();
    }
}

