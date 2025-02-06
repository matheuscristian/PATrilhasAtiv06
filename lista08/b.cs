using System;

namespace aaa
{
	class Program
	{
		public static void Main(string[] args)
		{
			int limit;
			Console.Write("Digite um número inteiro: ");
			limit = Math.Abs(int.Parse(Console.ReadLine()));
			
			for (int i = 0; i < limit + 2; i += 2) {
				Console.WriteLine(i);
			}
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}
