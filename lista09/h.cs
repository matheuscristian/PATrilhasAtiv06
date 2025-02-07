// C# Script para a versão do .Net 9.0

int[] v = { 2, 6, 43, 8, 5, 8, 3, 22, 66, 978, 24, 86, 324, 7, 5, 42, 4 };

Array.Sort(v, 0, v.Length);
Array.Reverse(v);

foreach (var num in v) {
    Console.Write($"{num} ");
}
Console.WriteLine();

Console.Write("Press any key to continue . . . ");
Console.ReadKey(true);
