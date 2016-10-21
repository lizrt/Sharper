using System;

namespace Example
{
	public class Shape
	{
		private int _sidea;
		private int _sideb;

		public int SideA
		{
			get
			{ 
				Console.WriteLine("calling getter on sidea");
				return _sidea;
			}
			set
			{
				Console.WriteLine("calling setter on sidea");

				_sidea=value;
			}
		}
		public int SideB
		{
			get
			{ 
				Console.WriteLine("calling getter on sideb");
				return _sideb;
			}
			set
			{
				Console.WriteLine("calling setter on sideb");
				_sideb=value;
			}
		}
		public Shape()
		{

		}
		public Shape(int sidea)
		{
			_sidea=sidea;
		}
		public Shape(int a, int b) : this(a)
		{
			
			_sideb=b;
		}

		public int GetArea(int a)
		{
			return a*a;
		}
		public int GetArea(int a, int b)
		{
			return a* b;
		}

		public int Area()
		{
			if(_sideb == 0)
				return _sidea*_sidea;
			else
				return _sidea*_sideb;
		}
	}
	public class Runner
	{
		public static void Main()
		{
			Shape sh=new Shape(9);
			Shape sh1=new Shape(4,3);
			String a; 
			a = "ABC";
			Shape sha=new Shape();
			Console.WriteLine("Square: "+sha.GetArea(2));
			Console.WriteLine("Rectangle: "+sha.GetArea(2,3));
			Console.WriteLine(sh.Area());
			Console.WriteLine(sh1.Area());
		}
	}
}