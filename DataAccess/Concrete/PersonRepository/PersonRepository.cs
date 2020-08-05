using Core.DataAccess;
using DataAccess.Abstract.IPersonRepo;
using Entity.Concrete;

namespace DataAccess.Abstract.PersonRepo
{
    public class PersonRepository : MongoDBDriverRepositoryBase<Person, IPersonRepositorySettings>, IPersonRepository
    {
        public PersonRepository(IPersonRepositorySettings repositorySettings) : base(repositorySettings)
        { }
    }
}