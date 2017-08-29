using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nthLargestNumber
{
    class Program
    {
        static void Main()
        {
            var numbers = new[] { 5, 7, 5, 3, 6, 7, 9 };
            int n = 4;
            var result = numbers.GroupBy(x => x)
                    .OrderByDescending(group => group.Key)
                    .Take(n)
                    .Select(group => group.Key)
                    .ToArray();
            Console.WriteLine("num={0}", result[3]);
            Console.ReadKey();

        }
    }
}
