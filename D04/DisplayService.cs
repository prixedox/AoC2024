using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D04
{
    internal class DisplayService
    {

        public static void PartOne(string filename)
        {
            var fs = new FileService();
            string[] content = fs.GetLineContent(filename);

            var ga = new GridAnalyzer();
            int count = ga.GetNumberOfXmas(content);

            Console.WriteLine("part one: {0}", count);
        }

        public static void PartTwo(string filename)
        {
            var fs = new FileService();
            string[] content = fs.GetLineContent(filename);

            var ga = new GridAnalyzer2();
            int count = ga.GetNumberOfXmas(content);

            Console.WriteLine("part two: {0}", count);
        }
    }
}
