using System;

namespace aaa
{
	class Program
	{
		public static void Main(string[] args)
		{
			long limit, sum = 0;
			Console.Write("Digite um número inteiro: ");
			limit = Math.Abs(int.Parse(Console.ReadLine()));
			
			for (int i = 1; i <= limit; i++) {
				sum += i;
			}
			
			Console.WriteLine(sum);
			
			Console.WriteLine("Jeito mais facil -- (limit * (limit + 1)) / 2  : ");
			Console.WriteLine((limit * (limit + 1)) / 2);
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}
