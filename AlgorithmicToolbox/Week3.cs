using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmicToolbox
{
    public class Week3
    {
        public int GetChange(int n)
        {
            int[] denominations = new int[] { 10, 5, 1 };
            int result = 0;

            while (n != 0)
            {
                for(int i = 0; i < denominations.Length; i++)
                {
                    int temp = n / denominations[i];

                    if (temp == 0)
                        continue;

                    result = result + temp;
                    n = n % denominations[i];

                    if (n == 0)
                        break;
                }
            }

            return result;
        }

        public decimal GetOptimalValue(int numItems, int totCapacity, int[,] valueWeights)
        {
            decimal resultWeight = 0;
            int totAvailableWeight = 0;

            decimal[] valuePerWeight = new decimal[numItems];

            for (int i = 0; i < numItems; i++)
            {
                valuePerWeight[i] = (decimal)valueWeights[i, 0] / valueWeights[i, 1];
                totAvailableWeight += valueWeights[i, 1];
            }

            totCapacity = Math.Min(totCapacity, totAvailableWeight);

            var valuePerWeightSorted = valuePerWeight.Select((v, i) => new KeyValuePair<decimal, int>(v, i)).OrderByDescending(x => x.Key).ToList();

            while (totCapacity != 0)
            {
                for(int i = 0; i < numItems; i++)
                {
                    if (totCapacity > valueWeights[valuePerWeightSorted[i].Value, 1])
                    {
                        totCapacity = totCapacity - valueWeights[valuePerWeightSorted[i].Value, 1];
                        resultWeight = resultWeight + valueWeights[valuePerWeightSorted[i].Value, 0];
                    }
                    else
                    {
                        resultWeight = resultWeight + (totCapacity * valuePerWeightSorted[i].Key);
                        totCapacity = 0;
                        break;
                    }
                }
            }

            return resultWeight;
        }

        public int MaximizeRevenueAdPlacement(int n, int[] proffitPerClick, int[] avgNumClickPerday)
        {
            Array.Sort(proffitPerClick);
            Array.Sort(avgNumClickPerday);

            int result = 0;

            for(int i = 0; i < n; i++)
                result += proffitPerClick[i] * avgNumClickPerday[i];

            return result;
        }
    }
}
