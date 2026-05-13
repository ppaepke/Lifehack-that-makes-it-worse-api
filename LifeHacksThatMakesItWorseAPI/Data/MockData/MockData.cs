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
        
    };


        public List<LifeHackEntity> LifeHackData = new List<LifeHackEntity>()
{
    new LifeHackEntity("Skip the alarm—wake up whenever you feel like it", 3),
    new LifeHackEntity("Use the same simple password for all accounts", 2),
    new LifeHackEntity("Store important documents only on a single USB stick", 8),
    new LifeHackEntity("Never read instructions—guess your way through gadgets", 12),
    new LifeHackEntity("Drink energy drinks all day instead of sleeping", 1),
    new LifeHackEntity("Ignore software updates to avoid interruptions", 2),
    new LifeHackEntity("Sell or delete backups once a new device is bought", 7),
    new LifeHackEntity("Use expired food first to save money", 10),
    new LifeHackEntity("Respond to every notification immediately to stay ‘on top’ of things", 3),
    new LifeHackEntity("Post sensitive personal info publicly to get faster help", 2),
    new LifeHackEntity("Never plan travel—pack the night before and forget essentials", 9),
    new LifeHackEntity("Ignore professional advice—DIY complex medical treatments", 1),
    new LifeHackEntity("Buy the cheapest replacement parts regardless of quality", 26),
    new LifeHackEntity("Keep all receipts in a single overflowing drawer", 8),
    new LifeHackEntity("Multitask during meetings—type, check social and eat", 13),
    new LifeHackEntity("Share login details with colleagues to save time", 2),
    new LifeHackEntity("Put wet dishes away immediately to save a minute", 3),
    new LifeHackEntity("Use a hairdryer to speed up drying of electrical items", 3),
    new LifeHackEntity("Ignore privacy settings—connect every app to your profile", 25),
    new LifeHackEntity("Store passwords in a text file on the desktop for convenience", 2),
    new LifeHackEntity("Skip regular toothbrushing when busy—chewing gum is enough", 1),
    new LifeHackEntity("Cancel insurance to reduce monthly bills; hope nothing happens", 8),
    new LifeHackEntity("Copy and paste code from the internet without reading it", 2),
    new LifeHackEntity("Use high heat to clean delicate fabrics quickly", 15),
    new LifeHackEntity("Postpone all decisions until they become urgent for a thrill", 2)
};


    }
}
