using MathSystem.Validations.Interfaces;

namespace MathSystem.Helpers.Interfaces
{
  /// <summary>
  /// Interface that represents a helper for discovery prime numbers.
  /// </summary>
  public interface IPrimeHelper : INumberValidation
  {
    /// <summary>
    /// Method that defines if a number is prime.
    /// </summary>
    /// <param name="number">Number to be checked.</param>
    /// <returns>true - if the number is prime.</returns>
    bool IsPrimeNumber(int number);

    /// <summary>
    /// Method that analyzes a list of numbers and finds which ones are prime.
    /// </summary>
    /// <param name="numbers">List of number to analyze</param>
    /// <returns>A list of prime numbers.</returns>
    IEnumerable<int> GetPrimeNumbers(IEnumerable<int> numbers);
  }
}