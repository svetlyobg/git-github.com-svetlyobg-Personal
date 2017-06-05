using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeshkaArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array; // декларация
            int[] array2 = new int[5];//инициализация
            int[] array3 = { 1, 2, 1, 1, 4 };
            int[] myArray = new int[6];
            myArray[1] = 1;
            myArray[0] = 745;
            myArray[5] = 5;            int[] arr = new int[5];
            arr[0] = 1;
            arr[1] = 2;
            arr[2] = 745;
            arr[3] = 800;
            arr[4] = 300;
            for (int i = 0; i <= arr.Length-1; i++)
            {
                Console.WriteLine(arr[i]);
            }

           // Console.WriteLine("Enter length of the array");

           // int n = Convert.ToInt32(Console.ReadLine());

           //int[] array5 = { 200,300,200};
           //
           //foreach (int index in array5)
           //{
           //    Console.WriteLine("Enter index {0}", index);
           //   // Console.ReadLine();
           //    Console.WriteLine(index);
           //}            //            //for (int i = 0; i < n; i++)
            //{
            //    Console.WriteLine("Enter index {0}",i);
            //    array5[i] = Int32.Parse(Console.ReadLine());
            //}
        }
    }
}
