using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Circle
    {

        static void Main(string[] args)
        {
            var radius = double.Parse(Console.ReadLine());
            var result = (radius * radius) * 3.14;
            Console.WriteLine("S =: {0}", result);
        }


    }
}