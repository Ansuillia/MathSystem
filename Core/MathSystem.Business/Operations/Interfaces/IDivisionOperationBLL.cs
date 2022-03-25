using MathSystem.Business.Validations.Interfaces;
using MathSystem.Domain.Models;

namespace MathSystem.Business.Interfaces
{
  /// <summary>
  /// Interface that represent a division operation
  /// </summary>
  public interface IDivisionOperationBLL : INumberValidation
  {
    /// <summary>
    /// Method that divide a number and discover all divisors.
    /// </summary>
    /// <param name="number">Number to be divided</param>
    /// <returns>A list of divisors of a number</returns>
    DivisorsModel GetDividers(int number);
  }
}
