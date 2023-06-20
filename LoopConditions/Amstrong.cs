using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopConditions
{
    internal class Amstrong
    {
        static void Main(string[] args)
        {
            int a, sum = 0, b;
            int n = Convert.ToInt32(Console.ReadLine());
            b = n;
            while (n > 0)
            {
                a = n % 10;
                sum = sum + (a * a * a);
                n = n / 10;
            }
            if (b == sum)
            {
                Console.WriteLine("Armstrong Numb.");
            }
            else
            {
                Console.WriteLine("Not Armstrong.");
            }
        }
    }
}
