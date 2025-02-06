using System;

namespace aaa
{
	class Program
	{
		public static void Main(string[] args)
		{
			bool primo = true;
			
			for (int num = 1; num <= 100; num++) {
				for (int i = 2; i < Math.Sqrt(num); i++) {
					if (num % i == 0) {
						primo = false;
						break;
					}
				}
				
				if (primo) {
					Console.WriteLine(num);
				} else {
					primo = true;
				}
			}
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}
