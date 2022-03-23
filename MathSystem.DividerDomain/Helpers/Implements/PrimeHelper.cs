using MathSystem.Helpers.Interfaces;

namespace MathSystem.Operations.Helpers.Implements
{
  public class PrimeHelper : IPrimeHelper
  {
    public IEnumerable<int> GetPrimeNumbers(IEnumerable<int> numbers)
    {
      return numbers.Where(x => IsPrimeNumber(x));
    }

    public bool IsPrimeNumber(int number)
    {
      if (number == 2) return true;

      if (!IsValidNumber(number)) return false;

      return !Enumerable.Range(2, (int)(Math.Sqrt(number)))
          .Any(x => number % x == 0);
    }

    /// <summary>
    /// <inheritdoc/>
    /// to be a possible prime number.
    /// </summary>
    /// <inheritdoc/>
    public bool IsValidNumber(int number)
    {
      if (number <= 1) return false;
      if (number % 2 == 0) return false;

      return true;
    }
  }
}
