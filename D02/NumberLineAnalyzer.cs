using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D02
{
    internal class NumberLineAnalyzer
    {
        public int GetSumOfSafe(List<List<int>> numbers)
        {
            int sum = 0;
            foreach (var line in numbers)
            {
                bool isSafe = IsDecreasing(line) || IsIncreasing(line);

                if (isSafe)
                {
                    sum++;
                }
            }
            return sum;
        }

        public int GetSumOfSafeWithError(List<List<int>> numbers)
        {
            int sum = 0;
            foreach (var line in numbers)
            {
                bool isSafe = IsDecreasing(line) || IsIncreasing(line) || CanBeMadeSafe(line);

                if (isSafe)
                {
                    sum++;
                }
            }
            return sum;
        }

        private bool IsIncreasing(List<int> line)
        {
            int previousNumber = line[0];
            for (int i = 1; i < line.Count; i++)
            {
                int difference = line[i] - previousNumber;
                if (!(difference >= 1 && difference <= 3))
                {
                    return false;
                }
                previousNumber = line[i];
            }
            return true;
        }

        private bool IsDecreasing(List<int> line)
        {
            int previousNumber = line[0];
            for (int i = 1; i < line.Count; i++)
            {
                int difference = previousNumber - line[i];
                if (!(difference >= 1 && difference <= 3))
                {
                    return false;
                }
                previousNumber = line[i];
            }
            return true;
        }

        private bool CanBeMadeSafe(List<int> line)
        {
            for (int i = 0; i < line.Count; i++)
            {
                var modifiedLine = new List<int>(line);
                modifiedLine.RemoveAt(i);

                if (IsIncreasing(modifiedLine) || IsDecreasing(modifiedLine))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
