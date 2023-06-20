using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopConditions
{
    internal class SumAllDigit
    {
        static void Main(string[] args)
        {
            int n, sum = 0;
            Console.WriteLine("Enter numb:");
            n = Convert.ToInt32(Console.ReadLine());
            while (n > 0)
            {
                int a = n % 10;
                sum = sum + a;
                n = n / 10;
            }
            Console.WriteLine(sum);
        }
    }
}
