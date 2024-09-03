using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace MongodbTest.Model
{
    public class UserDetail
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? Id { get; set; }

        [BsonElement("Name")]
        public string Name { get; set; } = null!;

        [BsonElement("Age")]
        public int? Age { get; set; } = null!;


        [BsonElement("Address")]
        public string Address { get; set; } = null!;

        [BsonElement("City")]
        public string City { get; set; } = null!;
    }
}
