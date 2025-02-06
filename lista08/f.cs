using System;

namespace aaa
{
	class Program
	{
		public static void Main(string[] args)
		{
			int num, max = Int32.MinValue;
			
			Console.WriteLine("Digite vários números (qualquer outra coisa para parar): ");
			for (;true;) {
				if (!int.TryParse(Console.ReadLine(), out num)) {
					break;
				}
				
				if (num > max) {
					max = num;
				}
			}
			
			Console.WriteLine(max);
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}
