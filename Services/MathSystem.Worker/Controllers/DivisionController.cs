using MathSystem.Repository;
using Microsoft.AspNetCore.Mvc;

namespace MathSystem.Worker.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class DivisionController : Controller
  {
    private IDivisionRepository _divisionRepository;

    public DivisionController(IDivisionRepository divisionRepository)
    {
      _divisionRepository = divisionRepository;
    }

    [HttpPost]
    public IActionResult MakeDivision([FromBody] int number)
    {
      // Envia o item pra processamento
      _divisionRepository.CallOperation(number);

      /*
       * Busca o resultado do processamento
       * Por não ter implementado um fila e um sistema de controle mais robusto
       * optei por inserir uma validação e uma recorrencia para que o resultado
       * somente seja retornado caso a validação seja satisfeita
       */
      var result = _divisionRepository.GetResult();
      while (result.Number != number)
      {
        result = _divisionRepository.GetResult();
      }
      
      return Ok(result);
    }
  }
}
