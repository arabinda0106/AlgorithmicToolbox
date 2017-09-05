using System;

namespace AlgorithmicToolbox
{
    class Week2_Last_Digit_Large_Fib_Number
    {
        public static void Main1(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            int result = 0;

            if (n == 0)
                result = 0;
            else if (n == 1)
                result = 1;
            else
            {
                int prev2 = 0;
                int prev1 = 1;

                for (int i = 2; i <= n; i++)
                {
                    result = (prev1 + prev2) % 10;
                    prev2 = prev1;
                    prev1 = result;
                }
            }

            Console.WriteLine(result % 10);

        }
    }
}
