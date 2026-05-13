
using Data.Entities;
using LifeHacksThatMakesItWorseAPI.Data.Entities;

namespace LifeHacksThatMakesItWorseAPI.Core.Interfaces
{
    public interface ILifeHackService
    {
        Task<List<LifeHackEntity>> GetTenAdvicesAsync();
        Task<List<Categories>> GetAllCategoriesAsync();
        Task<List<LifeHackEntity>> GetAdviceByCategoryAsync(int categoryId);
        Task<LifeHackEntity?> GetRandomAdviceAsync();
        Task<LifeHackEntity?> AddAdviceAsync(LifeHackEntity advice);
    }
}
