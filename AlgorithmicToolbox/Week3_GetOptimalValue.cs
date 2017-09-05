using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmicToolbox
{
    class Week3_GetOptimalValue
    {
        public static void Main1(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');

            int numItems = Convert.ToInt32(input[0]);
            int totCapacity = Convert.ToInt32(input[1]);

            int[,] valueWeights = new int[numItems, 2];

            for (int i = 0; i < numItems; i++)
            {
                string[] inputLine = Console.ReadLine().Split(' ');
                valueWeights[i, 0] = Convert.ToInt32(inputLine[0]);
                valueWeights[i, 1] = Convert.ToInt32(inputLine[1]);
            }

            Console.WriteLine(GetOptimalValue(numItems, totCapacity, valueWeights));
        }

        private static decimal GetOptimalValue(int numItems, int totCapacity, int[,] valueWeights)
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
                for (int i = 0; i < numItems; i++)
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
    }
}
