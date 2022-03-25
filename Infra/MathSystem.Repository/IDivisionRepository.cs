using MathSystem.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathSystem.Repository
{
  public interface IDivisionRepository
  {
    void CallOperation(int number);
    void MakeDivision();
    DivisorsModel GetResult();
  }
}
