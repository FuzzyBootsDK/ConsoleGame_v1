namespace ConsoleGame_v1;

public class Player
{
    public string PlayerName { get; private set; }
    public int PlayerLevel { get; private set; }
    public int PlayerHealth { get; private set; }
    public string PlayerClass { get; private set; }
    public string PlayerRace { get; private set; }
    public int AttackDamage { get; private set; }
    public int SpellDamage { get; private set; }
    public int DamageModifier { get; private set; }
    
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
                    AttackDamage = 15;
                    SpellDamage = 1;
                    DamageModifier = 1;
                }
                else
                {
                    AttackDamage = 10;
                    SpellDamage = 1;
                    DamageModifier = 1;
                }
                break;
            case "Warlock":
                if (playerRace == "Elf")
                {
                    AttackDamage = 1;
                    SpellDamage = 15;
                    DamageModifier = 1;
                }
                else
                {
                    AttackDamage = 1;
                    SpellDamage = 10;
                    DamageModifier = 1;
                }
                break;
            case "Rogue":
                if (playerRace == "Human")
                {
                    AttackDamage = 7;
                    SpellDamage = 7;
                    DamageModifier = 1;
                }
                else
                {
                    AttackDamage = 5;
                    SpellDamage = 5;
                    DamageModifier = 1;
                }
                break;
            default:
                AttackDamage = 1;
                SpellDamage = 1;
                DamageModifier = 1;
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
