using System;

namespace aaa
{
	class Program
	{
		public static void Main(string[] args)
		{
			for (int i = 1; i < 101; i++) {
				Console.WriteLine(i);
			}
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}
