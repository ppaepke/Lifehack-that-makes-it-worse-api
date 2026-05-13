using LifeHacksThatMakesItWorseAPI.Data.Entities;

namespace Data.Entities
{
    public class LifeHackEntity
    {
        public int? Id { get; set; }
        public string? LifeHack { get; set; }

        public int CategoryId { get; set; }
        public Categories Category { get; set; } = null!;

        public LifeHackEntity(string lifeHack, int categoryId)
        {
            LifeHack = lifeHack;
            CategoryId = categoryId;
        }
    }
}