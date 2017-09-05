using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmicToolbox
{
    class Week2_Huge_Fibonacci_Number_Modulo_m
    {
        public static void Main1(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');

            long n = Convert.ToInt64(input[0]), m = Convert.ToInt64(input[1]);

            Console.WriteLine(Huge_Fibonacci_Number_Modulo_m(n, m));
        }

        private static long Huge_Fibonacci_Number_Modulo_m(long n, long m)
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
                return fibModValues[(int) index];
            }

            return result;
        }

    }
}
