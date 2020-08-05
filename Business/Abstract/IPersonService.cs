using System.Collections.Generic;
using Entity.Concrete;

namespace Business.Abstract
{
    public interface IPersonService
    {
        List<Person> GetAll();
    }
}