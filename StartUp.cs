namespace ConsoleGame_v1;

public class StartUp
{
    public string? PlayerName { get; private set; }
    public string? PlayerRace { get; private set; }
    public string? PlayerClass { get; private set; }
    public int PlayerLevel { get; private set; }
    public int PlayerHealth { get; private set; }
    
    private string _playerName = String.Empty;
    private string _playerRace = String.Empty;
    private string _playerClass = String.Empty;

    public void Start()
    {
        Console.WriteLine("Welcome to the game!");
        Console.WriteLine("Please enter your desired player name:");
        PlayerName = Console.ReadLine().ToUpper();

        Console.Clear();
        while (_playerRace.ToUpper() != "HUMAN" && _playerRace.ToUpper() != "ELF" && _playerRace.ToUpper() != "DWARF")
        {
            Console.WriteLine("Please enter a valid player race:");
            Console.WriteLine("Human, Elf, or Dwarf?");
            _playerRace = Console.ReadLine().ToUpper();
            Console.Clear();
        }
        PlayerRace = _playerRace;

        while (_playerClass.ToUpper() != "WARRIOR" && _playerClass.ToUpper() != "WARLOCK" && _playerClass.ToUpper() != "ROGUE")
        {
            Console.WriteLine("Please enter a valid player class:");
            Console.WriteLine("Warrior, Warlock, or Rogue?");
            _playerClass = Console.ReadLine().ToUpper();
            Console.Clear();
        }
        PlayerClass = _playerClass;
        PlayerLevel = 1;
        PlayerHealth = 100;
    }
}