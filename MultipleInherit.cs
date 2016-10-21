using System;

namespace Example
{
	public abstract class BaseA 
	{
		public abstract int Weight();

		public string Hello()
		{
			Weight();
			return "hello";
		}
	}
	interface IBase1
	{
		int Volume();
	}
	public interface IBase2
	{
		int Area();
	}

	public class Concrete : BaseA, IBase1, IBase2
	{
		public int Volume() { return 0;}
		public int Area() { return 0; }
		public override int Weight() { return 0; }
	}


	public class Runner
	{
		public static void Main()
		{
			Concrete c = new Concrete();
			Console.WriteLine(c.Weight());
		}
	}
}