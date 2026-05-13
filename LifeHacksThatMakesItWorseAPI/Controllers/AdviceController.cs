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
       public async Task <ActionResult<List<LifeHackEntity>>> GetTenAdvices()
        {
            var advices = await _lifeHackService.GetTenAdvicesAsync();
            return Ok(advices);
        }

        [HttpGet("Category")]

        public async Task<ActionResult<List><LifeHackEntity>>> GetByCategory()



        

        
        
        


}     
}
