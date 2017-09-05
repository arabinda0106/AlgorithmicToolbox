using System;

namespace AlgorithmicToolbox
{
    class MaxPairwiseProduct
    {
        public static void Main1(string[] args)
        {
            var numOfInputs = Console.ReadLine();
            var inputs = Console.ReadLine();

            string[] inputNumbers = inputs.Split(' ');

            long pairProduct = 0;

            if (inputNumbers.Length == 2)
                pairProduct = long.Parse(inputNumbers[0]) * long.Parse(inputNumbers[1]);
            else
            {
                //We don't need to sort the whole set. We just need to find the largest number and the second largest number.

                long largestNum = long.Parse(inputNumbers[0]);
                int largestNumIndex = 0;

                for (int i = 1; i < inputNumbers.Length; i++)
                {
                    if (long.Parse(inputNumbers[i]) > largestNum)
                    {
                        largestNum = long.Parse(inputNumbers[i]);
                        largestNumIndex = i;
                    }
                }

                long secondLargestNum = long.Parse(inputNumbers[0]);
                int secondLargestNumIndex = 0;

                if (largestNumIndex == 0)
                {
                    secondLargestNum = long.Parse(inputNumbers[1]);
                    secondLargestNumIndex = 1;
                }

                for (int i = secondLargestNumIndex + 1; i < inputNumbers.Length; i++)
                {
                    if ((long.Parse(inputNumbers[i]) > secondLargestNum) && (i != largestNumIndex))
                        secondLargestNum = long.Parse(inputNumbers[i]);
                }

                pairProduct = largestNum * secondLargestNum;
            }

            Console.WriteLine(pairProduct);

        }
    }
}