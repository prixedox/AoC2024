using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace D01
{
    internal class SimilarityService
    {
        public List<int>[] Numbers { get; set; }

        public SimilarityService(List<int>[] numbers)
        {
            Numbers = numbers;
        }

        public int CalculateSimilarity()
        {
            var appearances = ComputeAppearanceNumber();
            int totalSimilarity = 0;

            foreach (var number in Numbers[0])
            {
                int similarity = 0;
                if (appearances.ContainsKey(number))
                {
                    similarity = number * appearances[number];
                }

                totalSimilarity += similarity;
            }

            return totalSimilarity;
        }

        private Dictionary<int, int> ComputeAppearanceNumber()
        {
            var numberCounts = new Dictionary<int, int>();

            foreach (int number in Numbers[1])
            {
                if (numberCounts.ContainsKey(number))
                {
                    numberCounts[number]++;
                }
                else
                {
                    numberCounts[number] = 1;
                }
            }

            return numberCounts;
        }
    }
}
