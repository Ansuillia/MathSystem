using MathSystem.Business.Interfaces;
using MathSystem.Domain.Models;

namespace MathSystem.Repository
{
  public class DivisionRepository : IDivisionRepository
  {
    private DivisorsModel _result;
    private int _number;

    private IDivisionOperationBLL _divisionOperationBLL;

    public DivisionRepository(IDivisionOperationBLL divisionOperationBLL)
    {
      _result = new DivisorsModel();
      _divisionOperationBLL = divisionOperationBLL;
    }

    public void CallOperation(int number)
    {
      _number = number;
    }

    public DivisorsModel GetResult()
    {
      lock(_result)
      {
        return _result;
      }
    }

    public void MakeDivision()
    {
      lock(_result)
      {
       _result = _divisionOperationBLL.GetDividers(_number);
      }
    }
  }
}