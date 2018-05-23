using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort_the_odd
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums ={5, 3,0, 2, 8, 1, 4};
            foreach (var n in nums)
                Console.Write(n + " ");

            var NewNums = SortArray(nums);

            Console.WriteLine();
            foreach (var n in NewNums)
                Console.Write(n + " ");

            Console.ReadKey();
        }

        public static int[] SortArray(int[] array)
        {
            var SortedNums = array.Where(t => t % 2 != 0 && t != 0)
                                    .OrderBy(t => t)
                                    .ToList<int>();
            return array.Select((t) => { if (t % 2 != 0 && t != 0){ int n = SortedNums[0]; SortedNums.RemoveAt(0); return n; }
                                         else return t;}).ToArray();
        }

    }
}
