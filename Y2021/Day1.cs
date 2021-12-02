using System;
using System.Linq;
using System.Collections.Generic;

namespace AdventOfCode.Y2021
{
    public class Day1 : Day
    {
        public override int SolvePart1()
        {
            IEnumerable<int> nums = this.GetInput(2021, 1).Select(x => int.Parse(x));
            return nums.Zip(nums.Skip(1), (x, y) => x < y).Count(x => x);
        }
        public override int SolvePart2()
        {
            int WINDOW_LENGTH = 3;

            int[] nums = this.GetInput(2021, 1).Select(x => int.Parse(x)).ToArray();
            int last_sum = 0;
            int countIncr = 0;

            for (int i = 0; i < WINDOW_LENGTH; i++)
            {
                last_sum += nums[i];
            }

            for (int i = WINDOW_LENGTH; i < nums.Length; i++)
            {
                int current_sum = last_sum;
                current_sum += nums[i];
                current_sum -= nums[i-WINDOW_LENGTH];
                if (current_sum > last_sum)
                    countIncr++;
            }
            return countIncr;
        }
    }
}

