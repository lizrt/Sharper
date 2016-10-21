using System;

namespace Examples
{
	public class EFG
	{
		DateTime time;
		int i;

		public void PrintVals()
		{
			Console.WriteLine("Val time {0}", time);
			Console.WriteLine("Val i {0}", i);
		}
	}
	public class SomeExample
	{
		public static void Main()
		{
			int? i = 32;
			DateTime time = new DateTime();
			if(i == 21)
			{
				time = new DateTime();
			}
			Console.WriteLine(i==null);
			Console.WriteLine(time);
			Console.WriteLine("-----");

			EFG e = new EFG();
			e.PrintVals();

		}
	}
}