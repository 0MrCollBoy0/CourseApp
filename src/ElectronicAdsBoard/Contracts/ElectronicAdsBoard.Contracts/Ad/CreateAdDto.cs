using System.Security.Cryptography;

namespace ElectronicAdsBoard.Contracts.Ad;

public class CreateAdDto
{
    public string Name { get; set; }
    public decimal Price { get; set; }
    public string Address { get; set; }
    public string[] Tags { get; set; }
    public string Description { get; set; }
    public Guid CategoryId { get; set; }
}