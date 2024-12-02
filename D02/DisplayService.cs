using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D02
{
    internal class DisplayService
    {

        public static void PartOne(string filename)
        {
            var fs = new FileService();
            string[] content = fs.GetLineContent(filename);

            var np = new NumberParser();
            var numbers = np.GetNumbers(content);

            var nla = new NumberLineAnalyzer();
            int sum = nla.GetSumOfSafe(numbers);

            Console.WriteLine("part one: {0}", sum);
        }

        public static void PartTwo(string filename)
        {
            var fs = new FileService();
            string[] content = fs.GetLineContent(filename);

            var np = new NumberParser();
            var numbers = np.GetNumbers(content);

            var nla = new NumberLineAnalyzer();
            int sum = nla.GetSumOfSafeWithError(numbers);

            Console.WriteLine("part two: {0}", sum);
        }
    }
}
