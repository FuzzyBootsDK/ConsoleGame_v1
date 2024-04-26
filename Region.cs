using System.Collections.Generic;
namespace ConsoleGame_v1;

public class Region
{
    private Dictionary<string, RegionModel> _predefinedRegions;
    public RegionModel RegionData { get; private set; }
    
    public Region()
    {
        RegionData = RegionData;
        // Initialize predefined regions
        _predefinedRegions = new Dictionary<string, RegionModel>()
        {
            { "Desert", new RegionModel {
                RegionName = "Desert",
                RegionLevel = 7,
                RegionDefence = 10,
                RegionEnemies = new List() {
                    new Enemy ("Sandworm",5,3,50), 
                    new Enemy ("Desert Ghost",4,2,30) 
                }}},
            { "Forest", new RegionModel {
                RegionName = "Forest",
                RegionLevel = 6,
                RegionDefence = 20,
                RegionEnemies = new List() {
                    new Enemy ("Forest Elf",6,4,75 ),
                    new Enemy ("Tree Ent", 5,4,60 )
                }}},
            { "Volcano", new RegionModel {
                RegionName = "Volcano",
                RegionLevel = 5,
                RegionDefence = 30,
                RegionEnemies = new List() {
                    new Enemy("Fire Beast",8,6,100),
                    new Enemy("Molten Giant",6,5,110) 
                }}},
            { "Mountain", new RegionModel {
                RegionName = "Mountain",
                RegionLevel = 4,
                RegionDefence = 25,
                RegionEnemies = new List() {
                    new Enemy ("Mountain Troll", 9,3,150), 
                    new Enemy ("Rock Golem", 3,9,150) 
                }}},
            { "Swamp", new RegionModel {
                RegionName = "Swamp",
                RegionLevel = 3,
                RegionDefence = 20,
                RegionEnemies = new List() { 
                    new Enemy ("Swamp Monster",10,7,150), 
                    new Enemy ("Water Spirit",9,9,200) 
                }}},
            { "Cave", new RegionModel {
                RegionName = "Cave",
                RegionLevel = 2,
                RegionDefence = 10,
                RegionEnemies = new List() {
                    new Enemy ("Cave Bat", 7,8,85), 
                    new Enemy("Stone Spider", 8,6,95)
                }}},
            { "Desert", new RegionModel {
                RegionName = "Plains",
                RegionLevel = 2,
                RegionDefence = 10,
                RegionEnemies = new List() {
                    new Enemy ("Crow",5,3,50),
                    new Enemy ("Mole",4,2,30)
                }}}
        };
    }
    
    public void ChangeRegion(string region)
    {
        if (_predefinedRegions.ContainsKey(region))
        {
            RegionData = _predefinedRegions[region];
        }
        else
        {
            Console.WriteLine("Region not found.");
        }
    }
}