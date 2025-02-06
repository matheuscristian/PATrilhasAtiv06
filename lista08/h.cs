using System;

namespace aaa
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.Write("Digite um número: ");
			int num = Math.Abs(int.Parse(Console.ReadLine()));
			
			for (int i = 1; i <= num / 2; i++) {
				if (num % i == 0) {
					Console.WriteLine(i);
				}
			}
			Console.WriteLine(num);
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}
