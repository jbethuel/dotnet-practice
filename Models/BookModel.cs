using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace dotnet_practice.Models;

public class Book
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string? Id { get; set; }

    [BsonElement("name")]
    public string BookName { get; set; } = null!;
}
