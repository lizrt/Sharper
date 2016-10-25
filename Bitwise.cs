using System;
// using System.FlagsAttribute;

namespace Example
{
	[Flags]
	enum Days {
		None = 0x0,
		Sunday = 0x1,
		Monday = 0x2,
		Tuesday = 0x4,
		Wednesday = 0x8,
		Thursday = 0x10,
		Friday = 0x20,
		Saturday = 0x40
	}
	
	public class BitWiseExample
	{
		public static void Main()
		{
			Days d = (Days)0x13;
			Console.WriteLine(d);
		}
	}	
}