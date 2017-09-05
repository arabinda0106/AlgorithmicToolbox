using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmicToolbox
{
    class Week2_Least_Common_Multiple
    {
        public static void Main1(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');

            int a = Convert.ToInt32(input[0]), b = Convert.ToInt32(input[1]);

            long leastCommonMultiple = 0;

            if (a == b)
                leastCommonMultiple = a;
            else
            {
                int greatestCommonDivisor = greatest_common_divisor(Math.Max(a, b), Math.Min(a, b));

                leastCommonMultiple = (long) a * b / greatestCommonDivisor;
            }

            Console.WriteLine(leastCommonMultiple);
        }

        private static int greatest_common_divisor(int a, int b)
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
    }
}
