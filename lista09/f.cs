// C# Script para a versão do .Net 9.0

var v1 = new int[5];
var v2 = new int[5];

Console.WriteLine("Digite 5 números: ");
for (int i = 0; i < 5; i++) {
    v1[i] = int.Parse(Console.ReadLine());
}
Console.WriteLine("Digite outros 5 números: ");
for (int i = 0; i < 5; i++) {
    v2[i] = int.Parse(Console.ReadLine());
}

var v3 = new int[5];

for (int i = 0; i < 5; i++) {
    v3[i] = v1[i] + v2[i];
}

Console.WriteLine("Soma deles: ");
foreach (var num in v3)
{
    Console.Write("{0} ", num);
}
Console.WriteLine("");

Console.Write("Press any key to continue . . . ");
Console.ReadKey(true);
