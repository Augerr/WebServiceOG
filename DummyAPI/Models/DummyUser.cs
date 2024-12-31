using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace DummyAPI.Models
{
    public class DummyUser : IDummyEntity
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? _Id { get; set; }
        [BsonElement("id")]
        public int Id { get; set; }
        public string EmployeeId { get; set; } = string.Empty;
        [BsonElement("firstName")]
        public string FirstName { get; set; } = string.Empty;
        [BsonElement("lastName")]
        public string LastName { get; set; } = string.Empty;
        public string Status { get; set; } = string.Empty;
        [BsonElement("email")]
        public string Email { get; set; } = string.Empty;
        public string Email2 { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
        public string State { get; set; } = string.Empty;
        public string PostalCode { get; set; } = string.Empty;
        public string Country { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;
        public DateTime DateOfBirth { get; set; }
        [BsonElement("role")]
        public required int RoleId { get; set; }
        public ICollection<DummyRight>? Rights { get; set; }
    }
}
