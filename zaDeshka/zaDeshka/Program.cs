using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zaDeshka
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your age");

            Deshka d = new Deshka();
            int ageInput = Convert.ToInt32(Console.ReadLine());
            d.Age = ageInput;

            Console.WriteLine($"Your age is {d.Age}");

        }
    }
}
