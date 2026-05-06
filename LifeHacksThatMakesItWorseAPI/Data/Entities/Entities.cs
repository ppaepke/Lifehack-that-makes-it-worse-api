using LifeHacksThatMakesItWorseAPI.Data.Entities;

namespace Data.Entities
{
    public class LifeHackEntity
    {
        public int Id { get; set; }
        public string LifeHack { get; set; }
        public Categories category { get; set; }
        
    }
}