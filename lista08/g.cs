using System;

namespace aaa
{
	class Program
	{
		public static void Main(string[] args)
		{
			for (int i = 5; i <= 10; i++) {
				for (int j = 1; j <= 10; j++) {
					Console.WriteLine("{0} x {1} = {2}", i, j, i*j);
				}
				Console.WriteLine();
			}
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}
