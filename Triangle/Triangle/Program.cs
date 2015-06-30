using System;

namespace Triangle
{
	public enum triangleType
	{
		scalene = 1, 
		isosceles = 2, 
		equilateral = 3,
		notATriangle = 4  
	}

	class Triangle
	{
		private int a;  
		private int b;   
		private int c; 
		private triangleType type;  

		public Triangle()
		{
			a = 1;
			b = 1;
			c = 1;
			type = triangleType.equilateral;
		}

		public void setSides( int sideOne, int sideTwo, int sideThree )
		{
			
			a = sideOne;
			b = sideTwo;
			c = sideThree;
			if (isTriangle ()) {
				calculateType ();
			}
		}
		public triangleType getType(){
			return type;
		}
		private void calculateType(){
			if (a == c && b == c)
				type = triangleType.equilateral;
			else if (a == b || a == c || b == c)
				type = triangleType.isosceles;
			else
				type = triangleType.scalene;
		}

		private bool isTriangle()
		{
			if (a <= 0 || b <= 0 || c <= 0) {
				this.type = triangleType.notATriangle;
				return false;
			} else {
				if (((a + b) > c) && ((a + c) > b) && ((b + c) > a)) {
					return true;
				} else {
					this.type = triangleType.notATriangle;
					return false;
				}
			}
		}


	}

	class MainClass
	{
		public static void Main (string[] args)
		{
		Triangle T = new Triangle ();
		int a;
		int b;
		int c;
		Console.WriteLine ("Enter side 1:");
			a = int.Parse (Console.ReadLine ());
		Console.WriteLine ("Enter side 2:");
			b = int.Parse (Console.ReadLine ());
		Console.WriteLine ("Enter side 3:");
			c = int.Parse (Console.ReadLine ());
		T.setSides (a, b, c);
			Console.WriteLine ("triangle type is: {0}", T.getType());
		}
	}
}
