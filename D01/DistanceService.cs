using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D01
{
    internal class DistanceService
    {
        public List<int>[] Numbers {  get; set; }

        public DistanceService(List<int>[] numbers)
        {
            Numbers = numbers;
        }

        public int CalculateDistance()
        {
            SortNumbers();

            int sum = ComputeSum();

            return sum;
        }

        private int ComputeSum()
        {
            int sum = 0;

            for (int i = 0; i < Numbers[0].Count; i++)
            {
                int distance = Math.Abs(Numbers[0][i] - Numbers[1][i]);
                sum += distance;
            }

            return sum;
        }

        private void SortNumbers()
        {
            Numbers[0].Sort();
            Numbers[1].Sort();
        }

    }
}
