using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmicToolbox
{
    class Week2_Last_Digit_Of_Sum_Of_Fibonacci_Numbers
    {
        public static void Main1(string[] args)
        {
            long n = Convert.ToInt64(Console.ReadLine());

            Console.WriteLine(Last_Digit_Of_Sum_Of_Fibonacci_Numbers(n));
        }

        private static long Last_Digit_Of_Sum_Of_Fibonacci_Numbers(long n)
        {
            //Pisano Nmumber is the sequence 0 1.

            long result = 0;

            List<long> lstSumValues = new List<long>();

            if (n == 0)
                result = 0;
            else if (n == 1)
                result = 1;
            else
            {
                lstSumValues.Add(0);
                lstSumValues.Add(1);

                bool occurenceOfFirstPisanoNumber = false, occurenceOfSecondPisanoNumber = false;

                long fibSum = 1;

                long prev2 = 0;
                long prev1 = 1;

                for (int i = 2; i <= n; i++)
                {
                    result = (prev1 + prev2) % 10;
                    fibSum = (fibSum + result) % 10;
                    lstSumValues.Add(fibSum);
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
                                lstSumValues.RemoveAt(lstSumValues.Count() - 1);
                                lstSumValues.RemoveAt(lstSumValues.Count() - 1);
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

                long index = n % lstSumValues.Count();
                result = lstSumValues[(int)index];
            }

            return result;
        }
    }
}
