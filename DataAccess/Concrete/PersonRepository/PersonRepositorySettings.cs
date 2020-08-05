using Core.Entity;

namespace Core.DataAccess.PersonRepo
{
    public class PersonRepositorySettings : IRepositorySettings
    {
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
        public string CollectionName { get; set; }
    }
}