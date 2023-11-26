using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Question1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //In the end of the program, run f(15)
            FizzOrBuzz(15);
        }

        static void FizzOrBuzz(int n)
        {
            //for loop to loop from 1 to n
            for (int i = 1; i <= n; i++)
            {
                //During the looping, when the counter is divided both 3 and 5, print "fizzbuzz"
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("fizzbuzz");
                }
                //During the looping, when the counter is divided by 3, print "fizz"
                else if (i % 3 == 0)
                {
                    Console.WriteLine("fizz");
                }

                //During the looping, when the counter is divided by 5, print "buzz"
                else if (i % 5 == 0)
                {
                    Console.WriteLine("buzz");
                }
                //else print out number
                else
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
