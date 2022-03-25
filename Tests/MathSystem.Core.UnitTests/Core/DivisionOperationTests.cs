using FluentAssertions;
using MathSystem.Business.Operations;
using Xunit;

namespace MathSystem.UnitTests
{
  public class DivisionOperationsTests
  {
    [Fact]
    public void DividerOperation_NumberThatHaveFourDivider_ShouldReturnFour()
    {
      var divider = new DivisionOperationBLL();

      var result = divider.GetDividers(15);

      result.Divisors.Should().HaveCount(4);
    }
  }
}