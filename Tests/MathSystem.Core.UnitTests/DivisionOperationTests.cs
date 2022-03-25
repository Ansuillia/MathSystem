using Xunit;
using MathSystem.Operations.Implements;
using FluentAssertions;
using Moq;

namespace MathSystem.UnitTests
{
  public class DivisionOperationsTests
  {
    [Fact]
    public void DividerOperation_NumberThatHaveFourDivider_ShouldReturnFour()
    {
      var divider = new DivisionOperation();

      var result = divider.GetDividers(15);

      result.Should().HaveCount(4);
    }
  }
}