using System.ComponentModel.DataAnnotations;

namespace LifeHacksThatMakesItWorseAPI.Data.Entities
{
    public class Categories
    {
        [Key]
        public int CategoryId { get; set; }
        public string Category { get; set; } = string.Empty;

        public Categories(string category)
        {
            Category = category;
        }
    }
}
