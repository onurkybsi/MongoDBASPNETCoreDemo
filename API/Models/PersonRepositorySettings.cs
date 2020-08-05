using DataAccess.Abstract.IPersonRepo;

namespace API.Models
{
    public class PersonRepositorySettings : IPersonRepositorySettings
    {
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
        public string CollectionName { get; set; }
    }
}