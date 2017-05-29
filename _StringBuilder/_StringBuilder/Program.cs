using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _StringBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            string capitalLetters = "ABCDEF";
            string lowerLetters = "abcdef";
                      

            Random rndGenetaror = new Random();
            StringBuilder password = new StringBuilder();

            password.Append("abcdef");
            password.Insert(3, "!");

            Console.WriteLine(capitalLetters[rndGenetaror.Next(0, capitalLetters.Length)]);
            for (int i = 0; i < 2; i++)
            {
                char symbol = capitalLetters[rndGenetaror.Next(0, capitalLetters.Length)];
                password.Append(symbol);
            }
            for (int i = 0; i < 2; i++)
            {
                char symbol = lowerLetters[rndGenetaror.Next(0, lowerLetters.Length)];
                password.Append(symbol);
            }
            Console.WriteLine(password.ToString());
        }
    }
}
