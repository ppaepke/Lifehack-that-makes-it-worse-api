using LifeHacksThatMakesItWorseAPI.Data.Interfaces;
using LifeHacksThatMakesItWorseAPI.Data;
using LifeHacksThatMakesItWorseAPI.Data.Context;
using Data.Entities;
using LifeHacksThatMakesItWorseAPI.Data.Entities;
using Microsoft.EntityFrameworkCore;


namespace LifeHacksThatMakesItWorseAPI.Data.AdviceRepo;

public class AdviceRepo : IAdviceRepo
{
    private readonly AppDbContext _context;

    public AdviceRepo(AppDbContext context)
    {
        _context = context;
    }

    public async Task<LifeHackEntity?> AddAdviceAsync(LifeHackEntity advice)
    {
        var result = await _context.LifeHacks.AddAsync(advice);
        await _context.SaveChangesAsync();
        return result.Entity;
    }

    public async Task<bool> DeleteAdviceAsync(int lifeHackId)
    {
        var advice = await _context.LifeHacks.FirstOrDefaultAsync(lh => lh.Id == lifeHackId);

        if (advice == null)
        {
            return false;
        }

        _context.LifeHacks.Remove(advice);
         await _context.SaveChangesAsync();

         return true;
    }

    public async Task<List<LifeHackEntity>> GetAdviceByCategoryAsync(string category)
    {
        var advice = await _context.LifeHacks.Where(lh => lh.Category.Category == category).ToListAsync();
        return advice;
    }

    public async Task<List<Categories>> GetAllCategoriesAsync()
    {
        var categories = await _context.Category.ToListAsync();
        return categories;
    }

    public async Task<LifeHackEntity?> GetRandomAdviceAsync()
    {
        var maxId = await _context.LifeHacks.MaxAsync(lh => lh.Id);
        var randomId = new Random().Next(1, (int)maxId);
        var advice = await _context.LifeHacks.FirstOrDefaultAsync(lh => lh.Id == randomId);
        
        return advice ?? null;
    }

    public async Task<List<LifeHackEntity>> GetTenAdvicesAsync()
    {
        var advice = await _context.LifeHacks.Take(10).ToListAsync();
        return advice;
    }

    public async Task<bool> SaveChangesAsync()
    {
        return await _context.SaveChangesAsync() > 0;
    }
}