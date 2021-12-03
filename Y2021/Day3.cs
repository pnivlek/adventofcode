using System;
using System.Linq;
using System.Collections.Generic;

namespace AdventOfCode.Y2021
{
    public class Day3 : Day
    {
        public override int SolvePart1()
        {
            List<string> lines = this.GetInput(2021, 3).Select(x => x).ToList();
            int[] onefreq = new int[lines[0].Length];
            foreach (string line in lines)
            {
                for (int i = 0; i < line.Length; i++)
                {
                    if (line[i] - '0' == 1)
                        onefreq[i] += 1;
                }
            }
            string gamma = "", epsilon = "";
            foreach (int i in onefreq)
            {
                gamma += (i < lines.Count / 2) ? "1" : "0";
                epsilon += (i > lines.Count / 2) ? "1" : "0";
            }
            return Convert.ToInt32(gamma, 2) * Convert.ToInt32(epsilon, 2);
        }

        public override int SolvePart2()
        {
            List<string> lines = this.GetInput(2021, 3).Select(x => x).OrderBy(x => x).ToList();
            List<string> oxys = lines;
            int j = 0;
            while (oxys.Count > 1)
            {
                int onefreq = 0;
                foreach (string line in oxys)
                {
                    if (line[j] - '0' == 1)
                        onefreq += 1;
                }
                oxys = oxys.Where(o => o[j] == (onefreq >= (oxys.Count + 1) / 2 ? '1' : '0')).ToList();
                j++;
            }
            List<string> co2s = lines;
            j = 0;
            while (co2s.Count > 1)
            {
                int onefreq = 0;
                foreach (string line in co2s)
                {
                    if (line[j] - '0' == 1)
                        onefreq += 1;
                }
                co2s = co2s.Where(o => o[j] == (onefreq >= (co2s.Count + 1) / 2 ? '0' : '1')).ToList();
                j++;
            }

            return Convert.ToInt32(oxys[0], 2) * Convert.ToInt32(co2s[0], 2);
        }
    }
}
