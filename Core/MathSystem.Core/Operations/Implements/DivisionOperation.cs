using MathSystem.Operations.Interfaces;

namespace MathSystem.Operations.Implements
{
  public class DivisionOperation : IDivisionOperation
  {
    public IEnumerable<int> GetDividers(int number)
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
    /// <inheritdoc/>
    /// for division operation.
    /// </summary>
    /// <inheritdoc/>
    public bool IsValidNumber(int number)
    {
      if (number == 0) return false;
      return true;
    }
  }
}
