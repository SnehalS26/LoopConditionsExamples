using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopConditions
{
    internal class whileLoop
    {
        static void Main(string[] args)
        {
            //Print the value from 1 to 50
            //int i = 1;
            //while (i <= 50)
            //{
            //    Console.WriteLine("Enter Value" +i);

            //    i++;
            //}

            //Print the value from 50 to 20
            //int i = 50;
            //do
            //{
            //   Console.WriteLine("Value is:" +i);
            //    i--;
            //}
            //while (i >= 20);

            //Print the even numbers from 1 to 100
            //int i = 1;
            //while (i<=100)
            //{
            //    if(i % 2 == 0)
            //    {
            //        Console.WriteLine($"Even Numb is:{i}");
            //    }
            //    i++;
            //}

            //Accept the number & print its table 
            Console.WriteLine("Enter number:");
            int a = Convert.ToInt32(Console.ReadLine());
            int i = 1;
            while (i <= 10)
            {
                Console.WriteLine(i * a);
                i++;
            }
        }
    }
}
