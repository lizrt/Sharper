using System;
namespace Test
{

	public class Complex
	{
		protected int A { get; set; }
		int B { get; set; }

		public Complex(int a, int b)
		{
			this.A = a;
			this.B = b;
		}

		public virtual void PrintThis()
		{
			Console.WriteLine("{0}+i({1})", A, B);
		}

		public Complex Add(Complex y)
		{
			return new Complex(this.A+y.A,this.B+y.B);
		}
	}

	public class HelloWorld : Complex
	{
		public HelloWorld(int a, int b) : base(a,b)
		{
			Console.WriteLine("Hello Constructor");
		}
		public static void Main()
		{
			// DelCalc del1=Calculate;
			HelloWorld hw = new HelloWorld(1,2);
			hw.PrintThis("luvu");
			Complex com1=new Complex(2,3);
			Complex com2=new Complex(5,6);
			Complex com3=com1.Add(com2);
			// com3.PrintThis();
			//Console.WriteLine(com3.A);
			hw.PrintThis();
			// int res=del1(3,4);
			Console.WriteLine("res");
		}
		public delegate int DelCalc(int a,int b);
		public static int Calculate(int a,int b)
		{
			int c=a+b;
			return c;
		}
		public void PrintThis()
		{
			Console.WriteLine("aaa");
		}

		public void PrintThis(HelloWorld c)
		{
			Console.WriteLine(c.A);
		}
		public void PrintThis(string msg)
		{
			Console.WriteLine(msg);
		}
	}
}