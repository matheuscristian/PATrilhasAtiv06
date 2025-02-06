using System;

namespace aaa
{
	class Program
	{
		public static void Main(string[] args)
		{
			int[] v = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
			
			foreach (int i in v) {
				Console.WriteLine(i);
			}
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}
