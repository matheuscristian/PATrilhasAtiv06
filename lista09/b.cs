using System;

namespace aaa
{
	class Program
	{
		public static void Main(string[] args)
		{
			string[] nomes = new string[5];
			int[][] notas = new int[][] { new int[2], new int[2], new int[2], new int[2], new int[2] };
			
			for (int i = 0; i < 5; i++) {
				Console.Write("Digite o nome do aluno: ");
				string nome = Console.ReadLine();
				nomes[i] = nome;
				
				Console.WriteLine("Digite as notas do aluno: ");
				for (int j = 0; j < 2; j++) {
					notas[i][j] = int.Parse(Console.ReadLine());
				}
			}
			
			for (int i = 0; i < 5; i++) {
				Console.WriteLine(nomes[i]);
				Console.WriteLine("Notas: {0}, {1}", notas[i][0], notas[i][1]);
				Console.WriteLine("Média: {0}", (notas[i][0] + notas[i][1]) / 2);
				Console.WriteLine("------------");
			}
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}
