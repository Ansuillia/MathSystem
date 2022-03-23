namespace MathSystem.Validations.Interfaces
{
  /// <summary>
  /// Interface that represent a number validation.
  /// </summary>
  public interface INumberValidation
  {
    /// <summary>
    /// This method have the purpose to check if a number is valid
    /// </summary>
    /// <param name="number">Number that must be checked</param>
    /// <returns> true - if number is valid</returns>
    bool IsValidNumber(int number);
  }
}