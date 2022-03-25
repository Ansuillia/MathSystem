using MathSystem.Console;
using System.Diagnostics;
using System.Text.RegularExpressions;

var sw = new Stopwatch();

Console.WriteLine("Bem vindo ao MathSystem Console");
Console.WriteLine("Digite um número:");
var input = Console.ReadLine();

if (input is null || string.IsNullOrWhiteSpace(input))
{
  Console.WriteLine("Nenhum número foi informado.");
  return;
}

if (!Regex.IsMatch(input, "[0-9]"))
{
  Console.WriteLine("O valor digitado precisa ser um número.");
  return;
}

// Nesse ponto tenho certeza de que o valor é numérico

var number = int.Parse(input);

sw.Start();
var result = await HttpConsoleClient.MakeDivision(number);
sw.Stop();


if (result is null)
  Console.WriteLine("Houve um problema com o processamento, por favor tente novamente.");

Console.WriteLine("Processamento concuído.");
Console.WriteLine($"Numero digitado: {result.Number}");
Console.WriteLine($"Divisores: {string.Join(",", result.Divisors)}");
Console.WriteLine($"Divisores primos: {string.Join(",", result.Primes)}");

Console.WriteLine($"Tempo total de processamento: {sw.ElapsedMilliseconds} ms");

Console.WriteLine("Obrigado por usar o MathSystem :)");

Console.ReadKey();


