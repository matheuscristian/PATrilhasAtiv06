using System;

namespace aaa
{
	class Program
	{
		public static void Main(string[] args)
		{
			long num;
			bool primo = true;
			Console.Write("Digite um número inteiro: ");
			num = Math.Abs(int.Parse(Console.ReadLine()));
			
			for (int i = 2; i < Math.Sqrt(num); i++) {
				if (num % i == 0) {
					primo = false;
					break;
				}
			}
			
			string res = primo ? "é primo" : "não é primo";
			Console.WriteLine(res);
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}
