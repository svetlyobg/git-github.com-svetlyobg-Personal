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
            bool exit = false;
            Deshka d = new Deshka();
            while (exit == false)
            {
                try
                {
                    Console.WriteLine("Enter your age");
                    int ageInput = Convert.ToInt32(Console.ReadLine());
                    d.Age = ageInput;
                    exit = true;
                }
                catch (Exception e)
                {

                    Console.WriteLine(e.Message);
                }
            }
            
            

            Console.WriteLine($"Your age is {d.Age}");

        }
    }
}
