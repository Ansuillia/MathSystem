using FakeItEasy;
using MathSystem.Domain.Models;
using MathSystem.Repository;
using MathSystem.Worker.Controllers;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xunit;

namespace MathSystem.UnitTests.Services.Worker
{
  public class DivisionControllerTests
  {
    [Fact]
    public void MakeDivision_NumberValid_Success()
    {
      var fakeDiviisionRepository = A.Fake<IDivisionRepository>();
      var model = new DivisorsModel
      {
        Number = 10,
        Divisors = A.Fake<List<int>>(),
        Primes = A.Fake<List<int>>(),
      };

      A.CallTo(() => fakeDiviisionRepository.GetResult()).Returns(model);

      var divisionController = new DivisionController(fakeDiviisionRepository);

      var result = divisionController.MakeDivision(10) as OkObjectResult;

      Assert.NotNull(result);
      Assert.True(result.StatusCode == 200);
    }
  }
}
