using MongoDB.Bson.Serialization.Attributes;
using System;

namespace MongoDbConsolDemo
{
    public class CustomerModel
    {
        [BsonId]
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public AddressModel PermenantAddress { get; set; }
        public AddressModel CurrentAddress { get; set; }
    }
}
