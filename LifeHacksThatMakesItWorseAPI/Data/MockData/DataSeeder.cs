using LifeHacksThatMakesItWorseAPI.Data.Context;

namespace LifeHacksThatMakesItWorseAPI.Data.MockData; 


public static class DataSeeder
{
    public static async Task SeedDataAsync(AppDbContext context)
    {

        //context.LifeHacks.Any() || 
        if (context.Category.Any())
            return;
        

        var Data = new MockData();

        await context.Category.AddRangeAsync(Data.CategoryData);
        //await context.LifeHacks.AddRangeAsync(Data.LifeHackData);

        await context.SaveChangesAsync();


    }
}