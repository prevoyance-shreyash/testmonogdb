using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace MetaData.Model
{
    public class MasterCollection2
    {

        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("Name")]
        public string Name { get; set; }

        [BsonElement("IdCode")]
        public string IdCode { get; set; }
        [BsonElement("DataType")]
        public string DataType { get; set; }
        [BsonElement("Mandatory")]
        public bool? Mandatory { get; set; }

        [BsonElement("RuleId")]
        public string RuleId { get; set; }


        [BsonElement("ReferenceCollectionCode")]
        public string ReferenceCollectionCode { get; set; }
        
    }
}
