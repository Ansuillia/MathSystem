namespace MathSystem.Business.Helpers
{
  public static class PrimeHelper
  {
    public static IEnumerable<int> GetPrimeNumbers(IEnumerable<int> numbers)
    {
      return numbers.Where(x => IsPrimeNumber(x));
    }

    public static bool IsPrimeNumber(int number)
    {
      if (number == 2) return true;

      if (!IsValidNumber(number)) return false;

      return !Enumerable.Range(2, (int)(Math.Sqrt(number)))
          .Any(x => number % x == 0);
    }

    private static bool IsValidNumber(int number)
    {
      if (number <= 1) return false;
      if (number % 2 == 0) return false;

      return true;
    }
  }
}
