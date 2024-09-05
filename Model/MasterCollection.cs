using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace MongodbTest.Model;

public class MasterCollection
{



    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)] 
    public string? Id { get; set; }

    [BsonElement("IdCode")]
    public string IdCode { get; set; }

    [BsonElement("Name")]
    public string Name { get; set; }

    [BsonElement("InstanceId")]
    public int? InstanceId { get; set; }


    [BsonElement("StatusId")]
    public int? StatusId { get; set; }


}
