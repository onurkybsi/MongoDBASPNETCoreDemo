using Core.DataAccess;
using Entity.Concrete;

namespace DataAccess.Abstract.IPersonRepo
{
    public interface IPersonRepository : IEntityRepository<Person>
    { }
}