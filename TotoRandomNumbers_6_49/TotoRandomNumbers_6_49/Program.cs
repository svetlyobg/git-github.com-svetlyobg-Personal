using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TotoRandomNumbers_6_49
{
    class Program
    {
        static void Main(string[] args)
        {
            Random generator = new Random();

            for (int i = 1; i < 7; i++)
            {
                int randomNumber = generator.Next(1, 50);
                Console.WriteLine($"Number {randomNumber}");
            }
            Console.ReadKey();

        }
    }
}
