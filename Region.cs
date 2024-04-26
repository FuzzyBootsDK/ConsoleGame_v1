using System.Collections.Generic;
namespace ConsoleGame_v1;

public class Region
{
    private Dictionary<string, RegionModel> predefinedRegions;
    public RegionModel RegionData { get; private set; }
    
    public Region()
    {
        RegionData = RegionData;
        // Initialize predefined regions
        predefinedRegions = new Dictionary<string, RegionModel>()
        {
            { "Desert", new RegionModel {
                RegionName = "Desert",
                RegionLevel = 2,
                RegionDefence = 10,
                RegionEnemies = new List<string>() { "Sandworm", "Desert Ghost" } }},
            { "Forest", new RegionModel {
                RegionName = "Forest",
                RegionLevel = 3,
                RegionDefence = 20,
                RegionEnemies = new List<string>() { "Forest Elf", "Tree Ent" } }},
            { "Volcano", new RegionModel {
                RegionName = "Volcano",
                RegionLevel = 5,
                RegionDefence = 30,
                RegionEnemies = new List<string>() { "Fire Beast", "Molten Giant" } }},
            { "Mountain", new RegionModel {
                RegionName = "Mountain",
                RegionLevel = 4,
                RegionDefence = 25,
                RegionEnemies = new List<string>() { "Mountain Troll", "Rock Golem" } }},
            { "Swamp", new RegionModel {
                RegionName = "Swamp",
                RegionLevel = 3,
                RegionDefence = 20,
                RegionEnemies = new List<string>() { "Swamp Monster", "Water Spirit" } }},
            { "Cave", new RegionModel {
                RegionName = "Cave",
                RegionLevel = 1,
                RegionDefence = 10,
                RegionEnemies = new List<string>() { "Cave Bat", "Stone Spider" } }}
        };
    }
    
    public void ChangeRegion(string region)
    {
        if (predefinedRegions.ContainsKey(region))
        {
            RegionData = predefinedRegions[region];
        }
        else
        {
            Console.WriteLine("Region not found.");
        }
    }
}