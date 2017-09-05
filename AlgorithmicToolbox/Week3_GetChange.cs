using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmicToolbox
{
    class Week3_GetChange
    {
        public static void Main1(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(GetChange(n));
        }

        private static int GetChange(int n)
        {
            int[] denominations = new int[] { 10, 5, 1 };
            int result = 0;

            while (n != 0)
            {
                for (int i = 0; i < denominations.Length; i++)
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
    }
}
