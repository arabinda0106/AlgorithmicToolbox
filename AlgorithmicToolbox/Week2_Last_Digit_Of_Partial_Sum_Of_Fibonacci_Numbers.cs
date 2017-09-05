using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmicToolbox
{
    class Week2_Last_Digit_Of_Partial_Sum_Of_Fibonacci_Numbers
    {
        public static void Main1(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');

            long m = Convert.ToInt64(input[0]), n = Convert.ToInt64(input[1]);

            Console.WriteLine(Last_Digit_Of_Partial_Sum_Of_Fibonacci_Numbers(m, n));
        }

        private static long Last_Digit_Of_Partial_Sum_Of_Fibonacci_Numbers(long m, long n)
        {
            //Pisano Nmumber is the sequence 0 1.

            long result = 0;

            List<long> lstPartialSumValues = new List<long>();

            lstPartialSumValues.Add(0);
            lstPartialSumValues.Add(1);

            bool occurenceOfFirstPisanoNumber = false, occurenceOfSecondPisanoNumber = false;

            long fibSum = 1;

            long prev2 = 0;
            long prev1 = 1;

            for (int i = 2; i <= n; i++)
            {
                result = (prev1 + prev2) % 10;
                fibSum = result % 10;
                lstPartialSumValues.Add(fibSum);
                prev2 = prev1;
                prev1 = result;

                if (occurenceOfFirstPisanoNumber == false && fibSum == 0)
                    occurenceOfFirstPisanoNumber = true;
                else
                {
                    if (occurenceOfFirstPisanoNumber == true)
                    {
                        if (fibSum == 1)
                        {
                            occurenceOfSecondPisanoNumber = true;
                            lstPartialSumValues.RemoveAt(lstPartialSumValues.Count() - 1);
                            lstPartialSumValues.RemoveAt(lstPartialSumValues.Count() - 1);
                            break;
                        }
                        else
                        {
                            if (fibSum != 0)
                            {
                                occurenceOfFirstPisanoNumber = false;
                                occurenceOfSecondPisanoNumber = false;
                            }
                        }
                    }
                }
            }

            long index1 = m % lstPartialSumValues.Count();
            long index2 = n % lstPartialSumValues.Count();

            long sum = 0;

            for (long i = index1; i <= index2; i++)
                sum = (sum % 10) + (lstPartialSumValues[(int)i] % 10);

            return sum % 10;
        }
    }
}
