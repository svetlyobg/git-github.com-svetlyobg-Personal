using System;

namespace ShapeClass
{
	public class Cone:Shape
	{
		double b,h;
		public Cone ()
		{
		}
		public Cone (double r, double h)
		{
			b = (Math.PI) * Math.Pow (r, 2);
		}
		public void GetInfo()
		{
			Console.WriteLine ();
		}
	}
}