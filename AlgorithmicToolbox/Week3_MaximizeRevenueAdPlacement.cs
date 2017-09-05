using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmicToolbox
{
    class Week3_MaximizeRevenueAdPlacement
    {
        public static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            int[] proffitPerClick = Console.ReadLine().Split(' ').Select(int.Parse).ToArray<int>();
            int[] avgNumClickPerday = Console.ReadLine().Split(' ').Select(int.Parse).ToArray<int>();

            Console.WriteLine(MaximizeRevenueAdPlacement(n, proffitPerClick, avgNumClickPerday));
        }

        private static int MaximizeRevenueAdPlacement(int n, int[] proffitPerClick, int[] avgNumClickPerday)
        {
            Array.Sort(proffitPerClick);
            Array.Sort(avgNumClickPerday);

            int result = 0;

            for (int i = 0; i < n; i++)
                result += proffitPerClick[i] * avgNumClickPerday[i];

            return result;
        }
    }
}
