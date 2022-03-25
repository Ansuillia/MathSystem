namespace MathSystem.Domain.Models
{
  public class DivisorsModel
  {
    public int Number { get; set; }
    public IList<int> Divisors { get; set; } = new List<int>();
    public IList<int> Primes { get; set; } = new List<int>();
  }
}