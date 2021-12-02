using System;
using System.Linq;
using System.Collections.Generic;

namespace AdventOfCode.Y2021
{
    public class Day2 : Day
    {
        public override int SolvePart1()
        {
            int x = 0, y = 0;
            List<Tuple<string, int>> dirs = this.GetInput(2021, 2).Select(x => new Tuple<string, int>(x.Split(" ")[0], int.Parse(x.Split(" ")[1]))).ToList();
            foreach (Tuple<string, int> dir in dirs)
            {
                switch (dir.Item1)
                {
                    case "up":
                        y -= dir.Item2;
                        break;
                    case "down":
                        y += dir.Item2;
                        break;
                    case "forward":
                        x += dir.Item2;
                        break;
                }
            }
            return x * y;
        }

        public override int SolvePart2()
        {
            int x = 0, y = 0, aim = 0;
            List<Tuple<string, int>> dirs = this.GetInput(2021, 2).Select(x => new Tuple<string, int>(x.Split(" ")[0], int.Parse(x.Split(" ")[1]))).ToList();
            foreach (Tuple<string, int> dir in dirs)
            {
                switch (dir.Item1)
                {
                    case "up":
                        aim -= dir.Item2;
                        break;
                    case "down":
                        aim += dir.Item2;
                        break;
                    case "forward":
                        x += dir.Item2;
                        y += dir.Item2 * aim;
                        break;
                }
            }
            return x * y;
        }
    }
}

