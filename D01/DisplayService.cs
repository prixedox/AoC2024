using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D01
{
    internal class DisplayService
    {

        public static void PartOne(string filename)
        {
            var fs = new FileService();
            string[] content = fs.GetLineContent(filename);

            var np = new NumberParser();
            var numbers = np.GetNumbers(content);

            var ds = new DistanceService(numbers);
            int result = ds.CalculateDistance();

            Console.WriteLine("part one: {0}", result);
        }

        public static void PartTwo(string filename)
        {
            var fs = new FileService();
            string[] content = fs.GetLineContent(filename);

            var np = new NumberParser();
            var numbers = np.GetNumbers(content);

            var ss = new SimilarityService(numbers);
            int result = ss.CalculateSimilarity();

            Console.WriteLine("part two: {0}", result);
        }
    }
}
