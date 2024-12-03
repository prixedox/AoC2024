using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace D03
{
    internal class TextParser
    {
        public int GetSum(string input)
        {
            var matches = ParseMuls(input);
            int sum = PerformSum(matches);

            return sum;
        }

        public int GetSumConditionally(string input)
        {
            var muls = ParseMuls(input);
            var dos = ParseDos(input);
            var donts = ParseDonts(input);

            int sum = GetAllConditionally(muls, dos, donts);

            return sum;
        }

        private int GetAllConditionally(
            MatchCollection muls,
            MatchCollection dos,
            MatchCollection donts)
        {
            int sum = 0;
            foreach (Match match in muls)
            {
                if (IsMulAllowed(match, dos, donts))
                {
                    sum += GetMultiplication(match);
                }
            }
            return sum;
        }

        private bool IsMulAllowed(Match mul, MatchCollection dos, MatchCollection donts)
        {
            Match? maxDo = dos.Where(x => x.Index < mul.Index).MaxBy(x => x.Index);
            Match? maxDont = donts.Where(x => x.Index < mul.Index).MaxBy(x => x.Index);

            if (maxDo == null && maxDont == null)
            {
                return true;
            }
            else if (maxDo != null && maxDont == null)
            {
                return true;
            }
            else if (maxDo == null && maxDont != null)
            {
                return false;
            }
            else
            {
                if (maxDo!.Index > maxDont!.Index)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        private int GetMultiplication(Match match)
        {
            string first = match.Groups[1].Value;
            string second = match.Groups[2].Value;

            int firstNumber = int.Parse(first);
            int secondNumber = int.Parse(second);

            return firstNumber * secondNumber;
        }

        private MatchCollection ParseMuls(string input)
        {
            string pattern = @"mul\((\d+),(\d+)\)";
            MatchCollection matches = Regex.Matches(input, pattern);

            return matches;
        }

        private MatchCollection ParseDos(string input)
        {
            string pattern = @"do\(\)";
            MatchCollection matches = Regex.Matches(input, pattern);

            return matches;
        }

        private MatchCollection ParseDonts(string input)
        {
            string pattern = @"don't\(\)";
            MatchCollection matches = Regex.Matches(input, pattern);

            return matches;
        }

        private int PerformSum(MatchCollection matches)
        {
            int sum = 0;
            foreach (Match match in matches)
            {
                string first = match.Groups[1].Value;
                string second = match.Groups[2].Value;

                int firstNumber = int.Parse(first);
                int secondNumber = int.Parse(second);

                sum += firstNumber * secondNumber;
            }
            return sum;
        }
    }
}
