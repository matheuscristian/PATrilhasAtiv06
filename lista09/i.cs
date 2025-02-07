// C# Script para a versão do .Net 9.0

var names = new string[10];

Console.WriteLine("Digite 10 nomes: ");
for (int i = 0; i < 10; i++) {
    names[i] = Console.ReadLine().Trim();
}

Console.WriteLine("Você digitou os seguintes nomes: ");
foreach (var name in names)
{
    Console.WriteLine($"-- {name}");
}

Console.Write("Press any key to continue . . . ");
Console.ReadKey(true);
