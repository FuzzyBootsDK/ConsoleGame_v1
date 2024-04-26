namespace ConsoleGame_v1;

public class Player
{
    public string PlayerName { get; private set; }
    public int PlayerLevel { get; private set; }
    public int PlayerHealth { get; private set; }
    public string PlayerClass { get; private set; }
    public string PlayerRace { get; private set; }
    public int attackDamage { get; private set; }
    public int spellDamage { get; private set; }
    public int damageModifier { get; private set; }
    
    public Player(string playerName, string playerClass, string playerRace, int playerLevel, int playerHealth)
    {
        PlayerName = playerName;
        PlayerLevel = playerLevel;
        PlayerHealth = playerHealth;
        PlayerClass = playerClass;
        PlayerRace = playerRace;
        switch (playerClass)
        {
            case "Warrior":
                if (playerRace == "Dwarf")
                {
                    attackDamage = 15;
                    spellDamage = 1;
                    damageModifier = 1;
                }
                else
                {
                    attackDamage = 10;
                    spellDamage = 1;
                    damageModifier = 1;
                }
                break;
            case "Warlock":
                if (playerRace == "Elf")
                {
                    attackDamage = 1;
                    spellDamage = 15;
                    damageModifier = 1;
                }
                else
                {
                    attackDamage = 1;
                    spellDamage = 10;
                    damageModifier = 1;
                }
                break;
            case "Rogue":
                if (playerRace == "Human")
                {
                    attackDamage = 7;
                    spellDamage = 7;
                    damageModifier = 1;
                }
                else
                {
                    attackDamage = 5;
                    spellDamage = 5;
                    damageModifier = 1;
                }
                break;
            default:
                attackDamage = 1;
                spellDamage = 1;
                damageModifier = 1;
                break;
        }
    }
    
    public void TakeDamage(int damage)
    {
        PlayerHealth -= damage;
    }
    
    public void Heal(int healAmount)
    {
        PlayerHealth += healAmount;
    }
    
    public void LevelUp()
    {
        PlayerLevel++;
    }
    
    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"Player Name: {PlayerName}");
        Console.WriteLine($"Player Race: {PlayerRace}");
        Console.WriteLine($"Player Class: {PlayerClass}");
        Console.WriteLine($"Player Level: {PlayerLevel}");
        Console.WriteLine($"Player Health: {PlayerHealth}");
    }
}
