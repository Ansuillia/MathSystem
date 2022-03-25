using MathSystem.Business.Helpers;
using MathSystem.Business.Interfaces;
using MathSystem.Domain.Models;

namespace MathSystem.Business.Operations
{
  public class DivisionOperationBLL : IDivisionOperationBLL
  {
    public DivisorsModel GetDividers(int number)
    {
      try
      {
        var divisors = MakeDivision(number);
        var primes = PrimeHelper.GetPrimeNumbers(divisors);

        return new DivisorsModel
        {
          Number = number,
          Divisors = divisors.OrderBy(n => n).ToList(),
          Primes = primes.OrderBy(n => n).ToList()
        };
      }
      catch (Exception ex)
      {
        throw new Exception(ex.Message);
      }
      
    }

    private IEnumerable<int> MakeDivision(int number)
    {
      if (IsValidNumber(number))
      {
        if (number <= 0) yield return default;

        var iterator = (int)Math.Sqrt(number);

        for (int i = 1; i <= iterator; i++)
        {
          if(number % i == 0) {

            yield return i;
            
            if(i != number / i ) yield return number / i;
          }
        }
      }
    }

    /// <summary>
    /// This method have the purpose to check if a number is valid for division.
    /// </summary>
    /// <param name="number">Number that must be checked</param>
    /// <returns>true - if number is valid</returns>
    public bool IsValidNumber(int number)
    {
      if (number == 0) return false;
      return true;
    }
  }
}
