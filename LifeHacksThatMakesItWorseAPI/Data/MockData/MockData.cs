using Data.Entities;
using LifeHacksThatMakesItWorseAPI.Data.Entities;

namespace LifeHacksThatMakesItWorseAPI.Data.MockData;

public class MockData
{
    public List<Categories> CategoryData =>
    [
        new Categories("Health"),
        new Categories("Technology")
    ];

    public List<(string Title, string CategoryName)> LifeHackData =>
[
    ("Skip job interviews and just start working there on Monday confidently", "Technology"),
    ("Save money on toothpaste by borrowing from your roommate's toothbrush", "Health"),
    ("Use airplane mode while driving to avoid traffic cameras", "Technology"),
    ("Never wash your gym clothes—let the bacteria build immunity", "Health"),
    ("Reply 'per my last email' even if you've never emailed them before", "Technology"),
    ("Cook faster by setting the oven to maximum and hoping for the best", "Health"),
    ("Store passwords on sticky notes for easier hacker accessibility", "Technology"),
    ("Drink pre-workout before bed to wake up energized", "Health"),
    ("Fix slow WiFi by yelling at the router", "Technology"),
    ("Cut your own hair right before important events to build character", "Health"),
    ("Ignore low battery warnings—they're mostly suggestions", "Technology"),
    ("Replace all vegetables with fries because potatoes are technically vegetables", "Health"),
    ("Update production on Friday evening to keep weekends exciting", "Technology"),
    ("Use your smoke detector battery in the TV remote during emergencies", "Health"),
    ("Never read terms and conditions—life is more fun with surprises", "Technology"),
    ("Skip leg day permanently to reduce laundry", "Health"),
    ("Use sunscreen only when the sun looks aggressive", "Health"),
    ("Test if milk is expired by taking a huge sip", "Health"),
    ("Keep 47 browser tabs open so your laptop never feels lonely", "Technology"),
    ("Fix bugs directly in production to save deployment time", "Technology"),
    ("Microwave fish at work to establish dominance", "Health"),
    ("Use the same pan without washing it to preserve flavor history", "Health"),
    ("Push directly to main so the whole team can learn together", "Technology"),
    ("If your code works, rewrite everything immediately", "Technology"),
    ("Sleep with your smartwatch on maximum brightness for a natural sunrise effect", "Health")
];
}