using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Time
{
    class Time
    {
        private int h=0;
        private int m=0;
        private int s=0;

        public Time (int h, int m, int s)
        {
            this.h = h%24;
            this.m = m%60;
            this.s = s%60;
        }

        public int Hour
        {
            get { return Hour; }
            set { Hour = value; }

        }

        public void Output()
        
            {
                Console.WriteLine("The time is: {0}:{1}:{2} ", h, m,s);
            }
                
        static void Main(string[] args)
        {
            Time t = new Time(2,18,0);
            t.Output();
        }
    }
}
