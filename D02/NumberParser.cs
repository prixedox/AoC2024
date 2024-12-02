using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D02
{
    internal class NumberParser
    {
        public List<List<int>> GetNumbers(string[] lines)
        {
            var matrix = new List<List<int>>();
            foreach (var line in lines)
            {
                var numberLine = new List<int>();
                string[] parts = line.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                foreach (var part in parts)
                {
                    int number = int.Parse(part);
                    numberLine.Add(number);
                }
                matrix.Add(numberLine);
            }

            return matrix;
        }
    }
}
