using MongoDB.Bson.Serialization.Attributes;

namespace Materials.Core
{
    public class Material
    {
        [BsonId]
        [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public string? Id { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public DateTime DateOfCreation { get; set; } = DateTime.Now;
        public IEnumerable<string> Tags { get; set; } = new List<string>();
    }
}
