using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopConditions
{
    internal class Fibonacci
    {
        static void Main(string[] args)
        {
            int n, first, second, third = 0;
            n = Convert.ToInt32(Console.ReadLine());
            first = 0;
            second = 1;
            Console.WriteLine(first + "\n " + second);
            for (int i = 0; i < n; i++)
            {

                third = first + second;
                Console.WriteLine(third);
                first = second;
                second = third;
            }
        }
    }
}
