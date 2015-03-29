using System;

namespace MoveIT_1.Models
{
    public interface IQuotation
    {
        string Id { get; set; }
        string Name { get; set; }
        string Email { get; set; }
        string FromStreet { get; set; }
        string FromCity { get; set; }
        string ToStreet { get; set; }
        string ToCity { get; set; }
        int DistanceInKm { get; set; }
        int LivingArea { get; set; }
        bool PianoMove { get; set; }
        bool PackageingHelp { get; set; }
        decimal EstimatedPrice { get; set; }
        DateTime LastModified { get; set; }
        int ExtraStorageArea { get; set; }
        int GetNumberOfCars();
        decimal GetDistancePrice();
        decimal GetPrice();
    }
}