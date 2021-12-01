using System;
using System.Linq;
using System.Collections.Generic;

namespace AdventOfCode
{
    public class Day1First : Day
    {
        public override int solve()
        {
            IEnumerable<int> nums = this.GetInput(1).Select(x => int.Parse(x));
            return nums.Zip(nums.Skip(1), (x, y) => x < y).Count(x => x);
        }
    }
}

