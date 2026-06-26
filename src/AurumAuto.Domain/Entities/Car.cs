namespace AurumAuto.Domain.Entities;

public class Car
{
    public int Id { get; set; }
    
    public string Model { get; set; } = string.Empty;
    public int Year { get; set; }
    public decimal Price { get; set; }
    public int Mileage { get; set; }
    public string Description { get; set; } = string.Empty;
    public bool IsAvailable  { get; set; } = true;
    
    public FuelType FuelType { get; set; }
    public Transmission Transmission {get; set;}
    
    public int BrandId{get; set;}
    public Brand Brand { get; set; } = null!;
}