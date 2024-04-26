using ConsoleGame_v1;

StartUp startUp = new StartUp();
startUp.Start();
Player player = new Player(startUp.PlayerName, startUp.PlayerClass, startUp.PlayerRace, startUp.PlayerLevel, startUp.PlayerHealth);
player.DisplayPlayerInfo();

