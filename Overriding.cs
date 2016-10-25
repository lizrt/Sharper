using System;

namespace Example
{
	public class Shape
	{
		private string _name;
		public string Name
		{
			get
			{
				return _name;
			}
			set
			{
				_name=value;
			}
		}
		public Shape(string name)
		{
			_name=name;
		}
		public virtual int Area()
		{
			Console.WriteLine("base Area");
			return 0;
		}
	}
	public class Square : Shape
	{
		private int _sidea;
		public int SideA{
			get{
				return _sidea;
			}
			set{
				_sidea=value;
			}
		}
		public Square(int sideA) : base("Square")
		{
			_sidea=sideA;
		}
		public override int Area()
		{
			Console.WriteLine("Area of {0}",Name);
			return _sidea*_sidea;
		}
	}
	public class Rectangle : Shape
	{
		private int _sidea;
		public int SideA{
			get{
				return _sidea;
			}
			set{
				_sidea=value;
			}
		}
		private int _sideb;
		public int SideB{
			get{
				return _sideb;
			}
			set{
				_sideb=value;
			}
		}
		public Rectangle(int sideA,int sideB) : base("Rectangle")
		{
			_sidea=sideA;
			_sideb=sideB;
			Console.WriteLine("Rectangle constructor");
		}
		public override int Area()
		{
			Console.WriteLine("Area of {0}",Name);
			return _sidea*_sideb;
		}
	}
	public class Runner
	{

		public static void PrintArea(Shape s)
		{
			Console.WriteLine(s.Area());
		}

		public static void Main()
		{
			Shape a = new Square(3);
			Shape b = new Rectangle(4,5);
			Shape c = new Square(8);

			PrintArea(a);
			PrintArea(b);
			PrintArea(c);
		}
	}
}