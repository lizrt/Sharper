using System;
namespace Example
{
	public  class Singleton
	{
		private static Singleton _instance;
		private Singleton()
		{
			Console.WriteLine("Constructor");
		}
		public static Singleton GetInstance()
		{
			if(_instance==null)
				_instance=new Singleton();

			return _instance;
		}

	}
	public class Runner
	{
		public static void Main()
		{
			Singleton ob=Singleton.GetInstance();
			Singleton ob1=Singleton.GetInstance();
			Console.WriteLine(ob.GetHashCode());
			Console.WriteLine(ob1.GetHashCode());
		}
	}
}