using System;

namespace ShapeClass
{
	public static class Shape
	{
		double S, r;
		public readonly double pi = Math.PI;
	}
		
	class MainClass
	{
		public static void Main (string[] args)
		{
			Dot d = new Dot ();
			Circle c = new Circle ();
			Cone co = new Cone ();
		}
	}
}
