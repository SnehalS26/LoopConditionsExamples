using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopConditions
{
    internal class ForLoopBasic
    {
        static void Main(string[] args)
        {
            //Print the value from 1 to 50

            //for (int i = 1; i <= 50; i++)
            //{
            //    Console.WriteLine($"Value {i}");
            //}

            ////Print the value from 50 to 20 
            //for (int i = 50; i >= 20; i--)
            //{
            //    Console.WriteLine($"Value {i}");
            //}

            ////Print the even numbers from 1 to 100
            //for (int i = 2; i <= 100; i++)
            //{
            //    if (i % 2 == 0)
            //{
            //    Console.WriteLine($"Even Number {i}");
            //}


            //Accept the number & print its table 
            //Console.WriteLine("Enter number:");
            //    int a = Convert.ToInt32(Console.ReadLine());
            //    for (int i = 1; i <= 10; i++)
            //    {
            //        Console.WriteLine(i * a);
            //    }

            //Write a program to print even numbers from 121 to 229 using for loop. 
            //for (int i = 121; i <= 229; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        Console.WriteLine($"Even Number {i}");
            //    }
            //}

            //Write a program to print odd numbers from 521 to 229 using while loop.
            //for (int i = 521; i >= 229; i--)
            //{
            //    if (i % 2 != 0)
            //    {
            //        Console.WriteLine($"Even Number {i}");
            //    }
            //}

            //Write a program to print all alphabets from a to z using for loop
            //for (char ch = 'a' ; ch <= 'z'; ch++)
            //{
            //        Console.WriteLine($"Alphabet {ch}");
            //}

            //WAP to print squares from 1 to 20
            for (int i = 1; i <= 20; i++)
            {
                int sum = 0;
                sum = i * i;
                Console.WriteLine(sum);
            }
        }
    }
}
