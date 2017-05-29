using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PointDistance
{

    class Point
    {
        private double x = 0;
        private double y = 0;

        public void Input()
        {
            Console.WriteLine("Input X value : ");
            string temp;
            temp = Console.ReadLine();
            x = Convert.ToDouble(temp);

            Console.WriteLine("Input Y value : ");
            string temp2;
            temp2 = Console.ReadLine();
            y = Convert.ToDouble(temp2);
        }

        public void Output()
        {
            Console.WriteLine("The cordinates of x- y- {0},{1} ", x, y);
        }

        public static double Distance(Point a, Point b)
        {
            return Math.Sqrt((a.x - b.x) * (a.x - b.x) + (a.y - b.y)*(a.y - b.y));

        }
        class Ravnina
        {
            static void Main(string[] args)
            {

                Point a = new Point();
                a.Input();
                a.Output();


                Point b = new Point();
                b.Input();

                double distance = Point.Distance(a, b);
                Console.WriteLine("The distance is: {0}", distance);
            }

        }
    }
}

