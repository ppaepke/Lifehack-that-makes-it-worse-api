    using Microsoft.AspNetCore.Mvc;
    using LifeHacksThatMakesItWorseAPI.Core.Interfaces;
    using LifeHacksThatMakesItWorseAPI.Data.Entities;
using Data.Entities;

namespace LifeHacksThatMakesItWorseAPI.Controllers
{


    [ApiController]
    [Route("api/[controller]")]
    public class AdviceController : ControllerBase
    {
        private readonly ILifeHackService _lifeHackService;

        public AdviceController(ILifeHackService lifeHackService)
        {
            _lifeHackService = lifeHackService;
        }

        [HttpGet]
        public async Task<ActionResult<List<LifeHackEntity>>> GetTenAdvices()
        {
            var advices = await _lifeHackService.GetTenAdvicesAsync();
            return Ok(advices);
        }

        [HttpGet("Category")]

        public async Task<ActionResult<List<LifeHackEntity>>> GetByCategory(int categoryId)
        {
            var advices = await _lifeHackService.GetAdviceByCategoryAsync(categoryId);
            return Ok(advices);
        }

        [HttpGet("Random")]

        public async Task<ActionResult<LifeHackEntity>> GetRandomAdvice()
        {
            var advice = await _lifeHackService.GetRandomAdviceAsync();
            if (advice == null)
            {
                return NotFound();
            }
            return Ok(advice);
        }

        [HttpGet("Categories")]

        public async Task<ActionResult<List<Categories>>> GetAllCategories()
        {
            var categories = await _lifeHackService.GetAllCategoriesAsync();
            return Ok(categories);
        }

        [HttpPost("AddAdvice")]
        public async Task<ActionResult<LifeHackEntity>> AddAdvice(LifeHackEntity advice)
        {
            var addedAdvice = await _lifeHackService.AddAdviceAsync(advice);
            if (addedAdvice == null)
            {
                return BadRequest();
            }
            return Ok(addedAdvice);
        }
        [HttpGet("GetAdviceByCategory")]
        public async Task<ActionResult<List<LifeHackEntity>>> GetAdviceByCategory(int categoryId)
        {
            var advices = await _lifeHackService.GetAdviceByCategoryAsync(categoryId);
            return Ok(advices);

        }

        public async Task<bool> DeleteAdvice(int lifeHackId)
        {
            return await _lifeHackService.DeleteAdviceAsync(lifeHackId);
        }
    }
}
