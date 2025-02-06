using System;

namespace aaa
{
	class Program
	{
		public static void Main(string[] args)
		{
			int sum = 0;
			for (int i = 1; i <= 100; i++) {
				if (i % 2 == 0) {
					sum += i;
				}
			}
			
			Console.WriteLine(sum);
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}
