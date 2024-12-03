using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D03
{
    internal class DisplayService
    {

        public static void PartOne(string filename)
        {
            var fs = new FileService();
            string content = fs.GetContent(filename);

            var tp = new TextParser();
            int result = tp.GetSum(content);

            Console.WriteLine("part one: {0}", result);
        }

        public static void PartTwo(string filename)
        {
            var fs = new FileService();
            string content = fs.GetContent(filename);

            var tp = new TextParser();
            int result = tp.GetSumConditionally(content);

            Console.WriteLine("part two: {0}", result);
        }
    }
}
