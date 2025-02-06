using System;
using System.Linq;

namespace aaa
{
	class Program
	{
		public static void Main(string[] args)
		{
			float[] v = {1.4f, 5.3f, 10.5f};
			
			Console.WriteLine(v.Sum() / v.Length);
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}
