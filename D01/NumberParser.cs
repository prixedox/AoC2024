using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D01
{
    internal class NumberParser
    {
        public List<int>[] GetNumbers(string[] lines)
        {
            var col1 = new List<int>();
            var col2 = new List<int>();
            foreach (var line in lines)
            {
                string[] parts = line.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                int firstNumber = int.Parse(parts[0]);
                int secondNumber = int.Parse(parts[1]);

                col1.Add(firstNumber);
                col2.Add(secondNumber);
            }

            return [col1, col2];
        }
    }
}
