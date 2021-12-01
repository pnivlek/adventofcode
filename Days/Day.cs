using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace AdventOfCode {
    public abstract class Day {
        public IEnumerable<string> GetInput(int day) {
            return File.ReadAllLines("../Input/Day" + day.ToString() + ".txt").AsEnumerable();
        }
        public abstract int solve();
    }
}

