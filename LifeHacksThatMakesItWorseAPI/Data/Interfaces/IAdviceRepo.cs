using Data.Entities;
using LifeHacksThatMakesItWorseAPI.Data.Entities;

namespace LifeHacksThatMakesItWorseAPI.Data.Interfaces; 

public interface IAdviceRepo
{
    Task<List<LifeHackEntity>> GetTenAdvicesAsync();
    Task<List<Categories>> GetAllCategoriesAsync();

    Task<List<LifeHackEntity>> GetAdviceByCategoryAsync(int categoryId);  

    Task<LifeHackEntity?> GetRandomAdviceAsync();

    Task<LifeHackEntity?> AddAdviceAsync(LifeHackEntity advice);

    Task<bool> DeleteAdviceAsync(int lifeHackId);

    Task<bool> SaveChangesAsync();
} 