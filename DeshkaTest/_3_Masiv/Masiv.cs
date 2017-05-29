using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Masiv
{
    class Masiv
    {
        static void Main(string[] args)
        {
            double sum = 0;
            double[] mx = new double[10];
            int i;

            for (i = 0; i < mx.Length; i++)
            {
                Console.WriteLine($"Enter number {i}");
                mx[i] = Double.Parse(Console.ReadLine());
            }

            Console.WriteLine($"The sum of the lements in the array is{ mx.Sum()}");
        }
    }
}
