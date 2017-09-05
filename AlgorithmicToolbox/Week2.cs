using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Numerics;

namespace AlgorithmicToolbox
{
    public class Week2
    {
        public long calc_fib(int n)
        {
            long result = 0;

            if (n == 0)
                result = 0;
            else if (n == 1)
                result = 1;
            else
            {
                long prev2 = 0;
                long prev1 = 1;

                for (int i = 2; i <= n; i++)
                {
                    result = prev1 + prev2;
                    prev2 = prev1;
                    prev1 = result;
                }
            }

            return result;
        }

        public long getFibonacciLastDigitNaive(long n)
        {
            long result = 0;

            if (n == 0)
                result = 0;
            else if (n == 1)
                result = 1;
            else
            {
                long prev2 = 0;
                long prev1 = 1;

                for (int i = 2; i <= n; i++)
                {
                    result = (prev1 + prev2) % 10;
                    prev2 = prev1;
                    prev1 = result;
                }
            }

            return (result % 10);
        }

        public int greatest_common_divisor(int a, int b)
        {
            int firstInt = a;
            int secondInt = b;
            int greatestDivisor = 0;

            for (;;)
            {
                int remainder = firstInt % secondInt;

                if (remainder != 0)
                {
                    firstInt = secondInt;
                    secondInt = remainder;
                }
                else
                {
                    greatestDivisor = secondInt;
                    break;
                }
            }

            return greatestDivisor;
        }

        public long Least_Common_MultipleSlow(long a, long b)
        {
            long leastCommonMultiple = 0;

            if (a == b)
                leastCommonMultiple = a;
            else
            {
                long smallerNum = a, largerNum = a;

                if (a > b)
                    smallerNum = b;
                else
                    largerNum = b;

                for (int i = 1; ; i++)
                {
                    long temp = largerNum * i;
                    if (temp % smallerNum == 0)
                    {
                        leastCommonMultiple = temp;
                        break;
                    }
                }
            }
             
            return leastCommonMultiple;
        }

        public long Least_Common_Multiple(int a, int b)
        {
            long leastCommonMultiple = 0;

            if (a == b)
                leastCommonMultiple = a;
            else
            {
                int greatestCommonDivisor = greatest_common_divisor(Math.Max(a, b), Math.Min(a, b));

                leastCommonMultiple = (long) a * b / greatestCommonDivisor;
            }

            return leastCommonMultiple;
        }

        public long Huge_Fibonacci_Number_Modulo_m(long n, long m)
        {
            //Pisano Nmumber is the sequence 0 1.
            long result = 0;

            if (n == 0)
                result = 0;
            else if (n == 1)
                result = 1;
            else
            {
                //List<long> fibValues = new List<long>();
                List<long> fibModValues = new List<long>();

                //fibValues.Add(0);
                //fibValues.Add(1);

                fibModValues.Add(0);
                fibModValues.Add(1);

                bool occurenceOfFirstPisanoNumber = false, occurenceOfSecondPisanoNumber = false;

                long prev2 = 0;
                long prev1 = 1;

                for (int i = 2; i <= n; i++)
                {
                    result = (prev1 + prev2) % m;
                    prev2 = prev1;
                    prev1 = result;

                    //fibValues.Add(result);
                    fibModValues.Add(result % m);

                    if (occurenceOfFirstPisanoNumber == false && result % m == 0)
                        occurenceOfFirstPisanoNumber = true;
                    else
                    {
                        if (occurenceOfFirstPisanoNumber == true)
                        {
                            if (result % m == 1)
                            {
                                occurenceOfSecondPisanoNumber = true;
                                fibModValues.RemoveAt(fibModValues.Count() - 1);
                                fibModValues.RemoveAt(fibModValues.Count() - 1);
                                break;
                            }
                            else
                            {
                                occurenceOfFirstPisanoNumber = false;
                                occurenceOfSecondPisanoNumber = false;
                            }
                        }
                    }
                }

                long index = n % fibModValues.Count();
                return fibModValues[(int)index];
            }

            return result;
        }

        public long Last_Digit_Of_Sum_Of_Fibonacci_Numbers(long n)
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

        public long Last_Digit_Of_Partial_Sum_Of_Fibonacci_Numbers(long m, long n)
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
