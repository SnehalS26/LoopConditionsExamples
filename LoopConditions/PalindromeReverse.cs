using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopConditions
{
    internal class PalindromeReverse
    {
        static void Main(string[] args)
        {
            int n, rem;
            n = Convert.ToInt32(Console.ReadLine());
            int rev = 0;
            while (n > 0)
            {
                rem = n % 10;
                n = n / 10;
                rev = (rev * 10) + rem;
            }
            Console.WriteLine(rev);

        }
    }
}
