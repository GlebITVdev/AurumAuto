using AurumAuto.Domain.Entities;

namespace AurumAuto.Infrastructure.Persistence;

public static class DbSeeder
{
    public static async Task SeedAsync(AppDbContext db)
    {
        if (db.Brands.Any())
            return;

        var bmw = new Brand { Name = "BMW" };
        var audi = new Brand { Name = "Audi" };
        var toyota = new Brand { Name = "Toyota" };

        var cars = new List<Car>
        {
            new Car
            {
                Brand = bmw, Model = "X5", Year = 2021, Price = 55000m,
                Mileage = 30000, FuelType = FuelType.Diesel,
                Transmission = Transmission.Automatic,
                Description = "Premium SUV in great condition."
            },
            new Car
            {
                Brand = audi, Model = "A6", Year = 2020, Price = 42000m,
                Mileage = 45000, FuelType = FuelType.Petrol,
                Transmission = Transmission.Automatic,
                Description = "Elegant business sedan."
            },
            new Car
            {
                Brand = toyota, Model = "Camry", Year = 2022, Price = 35000m,
                Mileage = 15000, FuelType = FuelType.Hybrid,
                Transmission = Transmission.Automatic,
                Description = "Reliable and economical hybrid."
            }
        };

        db.Cars.AddRange(cars);
        await db.SaveChangesAsync();
    }
}