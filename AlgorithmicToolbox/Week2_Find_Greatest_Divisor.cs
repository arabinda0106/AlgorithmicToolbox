using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmicToolbox
{
    class Week2_Find_Greatest_Divisor
    {
        public static void Main1(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            int a = Convert.ToInt32(input[0]);
            int b = Convert.ToInt32(input[1]);

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

            Console.WriteLine(greatestDivisor);
        }
    }
}
