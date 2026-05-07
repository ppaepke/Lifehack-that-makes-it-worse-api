using Data.Entities;
using LifeHacksThatMakesItWorseAPI.Core.Interfaces;
using LifeHacksThatMakesItWorseAPI.Data.AdviceRepo;
using LifeHacksThatMakesItWorseAPI.Data.Entities;
using LifeHacksThatMakesItWorseAPI.Data.Interfaces;
using Microsoft.AspNetCore.Http.HttpResults;


namespace LifeHacksThatMakesItWorseAPI.Core.Services
{
    public class LifeHackService : ILifeHackService
    {
        private readonly IAdviceRepo _adviceRepo;


        public LifeHackService(IAdviceRepo adviceRepo)
        {
            _adviceRepo = adviceRepo;
        }

        public async Task<LifeHackEntity?> AddAdviceAsync(LifeHackEntity advice)
        {
            

            

            var result = await _adviceRepo.AddAdviceAsync(advice);



            return result;
        }

        public async Task<List<LifeHackEntity>> GetAdviceByCategoryAsync(string category)
        {
            category = category.ToLower();

            var advice = await _adviceRepo.GetAdviceByCategoryAsync(category);

            return advice;
        }

        public async Task<List<Categories>> GetAllCategoriesAsync()
        {
            var categories = await _adviceRepo.GetAllCategoriesAsync();



            return categories;

        }

        public async Task<LifeHackEntity?> GetRandomAdviceAsync()
        {
            var advice = await _adviceRepo.GetRandomAdviceAsync();

            return advice;
        }

        public async Task<List<LifeHackEntity>> GetTenAdvicesAsync()
        {
            var advice = await _adviceRepo.GetTenAdvicesAsync();

            return advice;
            
        }
    }
}
