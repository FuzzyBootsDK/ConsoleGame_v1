using ConsoleGame_v1;

StartUp startUp = new();
startUp.Start();
Player player = new (startUp.PlayerName, startUp.PlayerClass, startUp.PlayerRace, startUp.PlayerLevel, startUp.PlayerHealth);
player.DisplayPlayerInfo();

