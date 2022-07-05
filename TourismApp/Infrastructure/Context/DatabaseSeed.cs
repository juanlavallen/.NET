using System.Text.Json;
using Core.Models;
using Microsoft.Extensions.Logging;

namespace Infrastructure.Context
{
    public class DatabaseSeed
    {

        public static async Task SeedAsync(ContextDb context, ILoggerFactory loggerFactory)
        {
            try
            {
                if (!context.Countries.Any())
                {
                    var countriesData = File.ReadAllText("../Infrastructure/Context/SeedData/countries.json");
                    var countries = JsonSerializer.Deserialize<List<Country>>(countriesData);

                    foreach (var item in countries)
                    {
                        await context.Countries.AddAsync(item);
                    }

                    await context.SaveChangesAsync();
                }

                if (!context.Categories.Any())
                {
                    var caegoriesData = File.ReadAllText("../Infrastructure/Context/SeedData/categories.json");
                    var categories = JsonSerializer.Deserialize<List<Category>>(caegoriesData);

                    foreach (var item in categories)
                    {
                        await context.Categories.AddAsync(item);
                    }

                    await context.SaveChangesAsync();
                }

                if (!context.Places.Any())
                {
                    var placesData = File.ReadAllText("../Infrastructure/Context/SeedData/places.json");
                    var places = JsonSerializer.Deserialize<List<Place>>(placesData);

                    foreach (var item in places)
                    {
                        await context.Places.AddAsync(item);
                    }

                    await context.SaveChangesAsync();
                }
            }
            catch (System.Exception exception)
            {
                var logger = loggerFactory.CreateLogger<DatabaseSeed>();
                logger.LogError(exception.Message);
            }
        }
    }
}