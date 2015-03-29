using System;
using MongoDB.Bson.Serialization.Attributes;

namespace MoveIT_1.Models
{
    public class Quotation
    {
        [BsonId]
        public string Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string FromStreet { get; set; }
        public string FromCity { get; set; }
        public string ToStreet { get; set; }
        public string ToCity { get; set; }
        public int DistanceInKm { get; set; }
        public int LivingArea { get; set; }
        public bool PianoMove { get; set; }
        public bool PackageingHelp { get; set; }
        public decimal EstimatedPrice { get; set; }
        public DateTime LastModified { get; set; }
    }
}