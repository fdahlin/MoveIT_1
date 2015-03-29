using System;
using MongoDB.Bson.Serialization.Attributes;

namespace MoveIT_1.Models
{
    public class Quotation : IQuotation
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
        public int ExtraStorageArea { get; set; }
        public decimal EstimatedPrice { get; set; }
        public DateTime LastModified { get; set; }

        public int GetNumberOfCars()
        {
            if (LivingArea < 0)
            {
                throw new ArgumentOutOfRangeException("livingArea");
            }
            if (ExtraStorageArea < 0)
            {
                throw new ArgumentOutOfRangeException("extraStorageArea");
            }
            LivingArea += ExtraStorageArea * 2;
            int numOfCars = 1;
            numOfCars += Convert.ToInt32(LivingArea / 50);
            return numOfCars;
        }

        public decimal GetDistancePrice()
        {
            if (DistanceInKm < 50)
            {
                return DistanceInKm * 10 + 1000;
            }
            if (DistanceInKm > 50 && DistanceInKm < 100)
            {
                return DistanceInKm * 8 + 5000;
            }
            return DistanceInKm * 7 + 10000;
        }

        public decimal GetPrice()
        {
            EstimatedPrice = GetNumberOfCars() * GetDistancePrice();
            return EstimatedPrice; // TODO maybe not return?
        }
    }


}