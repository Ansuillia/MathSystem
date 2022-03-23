using MathSystem.Core.Implements;
using MathSystem.Operations.Helpers.Implements;
using System.Diagnostics;

Console.WriteLine("Digite um número");
var input = Console.ReadLine();

if (!string.IsNullOrEmpty(input))
{
  DoWork(int.Parse(input));
}

void DoWork(int number)
{
  Console.WriteLine($"Numero de entrada: {number}");

  var operation = new DivisionOperation();
  var primeHelper = new PrimeHelper();

  var sw = Stopwatch.StartNew();

  var dividers = operation.GetDividers(number).OrderBy(n => n);

  Console.WriteLine($"Números divisores: {string.Join(",", dividers)}");

  var primes = primeHelper.GetPrimeNumbers(dividers);

  Console.WriteLine($"Divisores primos: {string.Join(",", primes)}");

  sw.Stop();
  long elapsed = sw.ElapsedMilliseconds; // or sw.ElapsedTicks
  Console.WriteLine("Total query time: {0} ms", elapsed);

  Console.WriteLine("Press any key to exit.");
  Console.ReadKey();
}