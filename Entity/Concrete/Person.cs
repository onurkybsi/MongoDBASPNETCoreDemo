using System;
using Core.Entity;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Entity.Concrete
{
    public class Person : IEntity
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        [BsonElement("firstName")]
        public string FirstName { get; set; }
        [BsonElement("lastName")]
        public string LastName { get; set; }
        [BsonElement("birthdate")]
        public DateTime Birthdate { get; set; }
        [BsonElement("email")]
        public string Email { get; set; }
    }
}