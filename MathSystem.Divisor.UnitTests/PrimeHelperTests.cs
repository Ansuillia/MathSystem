﻿using FluentAssertions;
using MathSystem.Operations.Helpers.Implements;
using System.Linq;
using Xunit;

namespace MathSystem.UnitTests
{
  public class PrimeHelperTests
  {
    [Theory]
    [InlineData(2)]
    [InlineData(3)]
    [InlineData(5)]
    [InlineData(7)]
    public void IsPrime_NumberIsPrime_ShouldHaveReturnTrue(int number)
    {
      var primeOperation = new PrimeHelper();

      var result = primeOperation.IsPrimeNumber(number);

      result.Should().BeTrue();
    }

    [Fact]
    public void GetPrimeNumbers_ListWithFivePrimeNumbers_ShouldReturnCorrectCount()
    {
      var list = Enumerable.Range(0, 12);
      var primeOperation = new PrimeHelper();
      var result = primeOperation.GetPrimeNumbers(list);

      result.Count().Should().Be(5);
    }

    [Fact]
    public void GetPrimeNumbers_ListWithMillionPrimeNumbers_ShouldExecuteCorrect()
    {
      var list = Enumerable.Range(0, 1000000);
      var primeOperation = new PrimeHelper();
      var result = primeOperation.GetPrimeNumbers(list);

      result.Count().Should().Be(78498);
    }
  }
}
