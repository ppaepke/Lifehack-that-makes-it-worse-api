using Data.Entities;
using LifeHacksThatMakesItWorseAPI.Data.Entities;

namespace LifeHacksThatMakesItWorseAPI.Data.MockData
{
    public class MockData
    {
        public List<Categories> CategoryData = new List<Categories>()
    {
        new Categories("Health"),
        new Categories("Technology"),
        new Categories("Lifestyle"),
        new Categories("Education"),
        new Categories("Entertainment"),
        new Categories("Sports"),
        new Categories("Business"),
        new Categories("Finance"),
        new Categories("Travel"),
        new Categories("Food"),
        new Categories("Science"),
        new Categories("Gaming"),
        new Categories("Music"),
        new Categories("Movies"),
        new Categories("Fashion"),
        new Categories("Fitness"),
        new Categories("Politics"),
        new Categories("Environment"),
        new Categories("History"),
        new Categories("Programming"),
        new Categories("Art"),
        new Categories("Photography"),
        new Categories("Books"),
        new Categories("News"),
        new Categories("Culture"),
        new Categories("DIY"),
        new Categories("Parenting"),
        new Categories("Relationships"),
        new Categories("Mental Health"),
        new Categories("Space")
    };


        public List<LifeHackEntity> LifeHackData = new List<LifeHackEntity>()
        {
            new LifeHackEntity("Skip the alarm—wake up whenever you feel like it", new Categories("Lifestyle")),
            new LifeHackEntity("Use the same simple password for all accounts", new Categories("Technology")),
            new LifeHackEntity("Store important documents only on a single USB stick", new Categories("Finance")),
            new LifeHackEntity("Never read instructions—guess your way through gadgets", new Categories("DIY")),
            new LifeHackEntity("Drink energy drinks all day instead of sleeping", new Categories("Health")),
            new LifeHackEntity("Ignore software updates to avoid interruptions", new Categories("Technology")),
            new LifeHackEntity("Sell or delete backups once a new device is bought", new Categories("Business")),
            new LifeHackEntity("Use expired food first to save money", new Categories("Food")),
            new LifeHackEntity("Respond to every notification immediately to stay ‘on top’ of things", new Categories("Lifestyle")),
            new LifeHackEntity("Post sensitive personal info publicly to get faster help", new Categories("Privacy")),
            new LifeHackEntity("Never plan travel—pack the night before and forget essentials", new Categories("Travel")),
            new LifeHackEntity("Ignore professional advice—DIY complex medical treatments", new Categories("Health")),
            new LifeHackEntity("Buy the cheapest replacement parts regardless of quality", new Categories("DIY")),
            new LifeHackEntity("Keep all receipts in a single overflowing drawer", new Categories("Finance")),
            new LifeHackEntity("Multitask during meetings—type, check social and eat", new Categories("Productivity")),
            new LifeHackEntity("Share login details with colleagues to save time", new Categories("Technology")),
            new LifeHackEntity("Put wet dishes away immediately to save a minute", new Categories("Lifestyle")),
            new LifeHackEntity("Use a hairdryer to speed up drying of electrical items", new Categories("Safety")),
            new LifeHackEntity("Ignore privacy settings—connect every app to your profile", new Categories("Privacy")),
            new LifeHackEntity("Store passwords in a text file on the desktop for convenience", new Categories("Technology")),
            new LifeHackEntity("Skip regular toothbrushing when busy—chewing gum is enough", new Categories("Health")),
            new LifeHackEntity("Cancel insurance to reduce monthly bills; hope nothing happens", new Categories("Finance")),
            new LifeHackEntity("Copy and paste code from the internet without reading it", new Categories("Programming")),
            new LifeHackEntity("Use high heat to clean delicate fabrics quickly", new Categories("Fashion")),
            new LifeHackEntity("Postpone all decisions until they become urgent for a thrill", new Categories("Mental Health"))
        }; // Add more life hacks as needed
    }
}