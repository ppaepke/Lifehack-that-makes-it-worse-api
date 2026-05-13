using Data.Entities;
using LifeHacksThatMakesItWorseAPI.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace LifeHacksThatMakesItWorseAPI.Data.MockData; 


public static class DataSeeder
{
    public static async Task SeedDataAsync(AppDbContext context)
    {
        if (await context.Category.AnyAsync() || await context.LifeHacks.AnyAsync())
            return;

        var data = new MockData();

        await context.Category.AddRangeAsync(data.CategoryData);
        await context.SaveChangesAsync();

        var categories = await context.Category.ToListAsync();

        var lifeHacks = data.LifeHackData.Select(x =>
        {
            var category = categories.First(c => c.Category == x.CategoryName);

            return new LifeHackEntity(
                x.Title,
                category.CategoryId
            );
        }).ToList();

        await context.LifeHacks.AddRangeAsync(lifeHacks);
        await context.SaveChangesAsync();
    }
}