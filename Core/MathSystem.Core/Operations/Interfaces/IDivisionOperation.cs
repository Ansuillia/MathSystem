using MathSystem.Validations.Interfaces;

namespace MathSystem.Operations.Interfaces
{
  /// <summary>
  /// Interface that represent a division operation
  /// </summary>
  public interface IDivisionOperation : INumberValidation
  {
    /// <summary>
    /// Method that divide a number and discover all divisors.
    /// </summary>
    /// <param name="number">Number to be divided</param>
    /// <returns>A list of divisors of a number</returns>
    IEnumerable<int> GetDividers(int number);
  }
}
