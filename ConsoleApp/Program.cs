using Core;
using System.Diagnostics.Metrics;
using System.Reflection.Metadata;

namespace ConsoleApp
{
    internal class Program
    {
        // COPY PASTE input.txt
        //First Blood
        //Sharp Shooter
        //Master Explorer
        //Speed Runner
        //Collector Supreme
        //Portal Runner
        //Sky Invaders
        //Tower Defense X
        //Chrono War
        //Dragon Realm
        //Alice
        //Bob
        //Charlie
        //Diana
        //Eve
        //Frank
        //Grace
        //Heidi
        //Ivan
        //Judy
        //Ubisoft
        //Valve
        //EA Games
        //Bethesda
        //Capcom
        //0 0
        //1 1
        //2 2
        //3 3
        //4 4
        // input.txt ^^^^^^^^^^^^^

        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            // replica na steam
            Inputs.InputIt();
            Intro();

            while (true)
            {
                ShowWAT();
                int input = int.Parse(Console.ReadLine());
                WhatsTheCase(input);
            }
        }

        public static void ShowWAT()
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("1. Изведи всички NeSteam играчи");
            Console.WriteLine("2. Изведи всички NeSteam създатели");
            Console.WriteLine("3. Изведи всички NeSteam игри");
            Console.WriteLine("4. Изведи всички NeSteam постижения");
            Console.WriteLine("5. Изведи всички NeSteam копмании за игри");
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("6. Изведи всички игри, които има играч");
            Console.WriteLine("7. Изведи всички постижения, които има игра");
            Console.WriteLine("8. Изведи всички игри, които има компания");
            Console.WriteLine("9. Изведи всички постижения, които има играч");
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("10. Изведи всички постижения от всички компании");
            Console.WriteLine("11. Изведи всички играчи от всички компании");
            Console.WriteLine("-----------------------------------------");
        }

        public static void Intro()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("  .-')     .-') _       ('-.      ('-.      _   .-')           _  .-')      ('-.      _ (`-.                                      ('-.     \r\n");
            Console.WriteLine(" ( OO ).  (  OO) )    _(  OO)    ( OO ).-. ( '.( OO )_        ( \\( -O )   _(  OO)    ( (OO  )                                    ( OO ).-.");
            Console.WriteLine("(_)---\\_) /     '._  (,------.   / . --. /  ,--.   ,--.)       ,------.  (,------.  _.`     \\  ,--.        ,-.-')     .-----.    / . --. /");
            Console.WriteLine("/    _ |  |'--...__)  |  .---'   | \\-.  \\   |   `.'   |        |   /`. '  |  .---' (__...--''  |  |.-')    |  |OO)   '  .--./    | \\-.  \\");
            Console.WriteLine("\\  :` `.  '--.  .--'  |  |     .-'-'  |  |  |         |        |  /  | |  |  |      |  /  | |  |  | OO )   |  |  \\   |  |('-.  .-'-'  |  | \r\n");
            Console.WriteLine(" '..`''.)    |  |    (|  '--.   \\| |_.'  |  |  |'.'|  |        |  |_.' | (|  '--.   |  |_.' |  |  |`-' |   |  |(_/  /_) |OO  )  \\| |_.'  | \r\n");
            Console.WriteLine(".-._)   \\    |  |     |  .--'    |  .-.  |  |  |   |  |        |  .  '.'  |  .--'   |  .___.' (|  '---.'  ,|  |_.'  ||  |`-'|    |  .-.  | \r\n");
            Console.WriteLine("\\       /    |  |     |  `---.   |  | |  |  |  |   |  |        |  |\\  \\   |  `---.  |  |       |      |  (_|  |    (_'  '--'\\    |  | |  | \r\n");
            Console.WriteLine(" `-----'     `--'     `------'   `--' `--'  `--'   `--'        `--' '--'  `------'  `--'       `------'    `--'       `-----'    `--' `--' ");
        }

        public static void WhatsTheCase(int command)
        {
            switch (command)
            {
                case 1:
                    // Изведи всички NeSteam играчи
                    List<string> allPlayers = PlayerController.DisplayAllPlayers();
                    Console.WriteLine("Всички NeSteam играчи:");
                    foreach (string playerName in allPlayers)
                    {
                        Console.WriteLine(playerName);
                    }
                    
                    break;
                case 2:
                    // Изведи всички NeSteam създатели
                    List<string> allCreators = CreatorController.DisplayAllCreators();
                    Console.WriteLine("Всички NeSteam създатели:");
                    foreach (string creatorName in allCreators)
                    {
                        Console.WriteLine(creatorName);
                    }
                    break;
                case 3:
                    // Изведи всички NeSteam игри
                    List<string> allGames = GameController.DisplayAllGames();
                    Console.WriteLine("Всички NeSteam игри:");
                    foreach (string gameName in allGames)
                    {
                        Console.WriteLine(gameName);
                    }
                    break;
                case 4:
                    // Изведи всички NeSteam постижения
                    List<string> allAchievements = AchievementController.DisplayAllAchievements();
                    Console.WriteLine("Всички NeSteam постижения");
                    foreach (string achievementName in allAchievements)
                    {
                        Console.WriteLine(achievementName);
                    }
                    break;
                case 5:
                    // Изведи всички NeSteam компании за игри
                    List<string> allGameCompanies = GameCompanyController.DisplayAllGameCompanies();
                    Console.WriteLine("Всички NeSteam компании за игри:");
                    foreach (string companyName in allGameCompanies)
                    {
                        Console.WriteLine(companyName);
                    }
                    break;
                case 6:
                    // Изведи всички игри, които има играч
                    Console.Write("Въведи ID на играча, за да видиш игрите му: ");
                    int playerId = int.Parse(Console.ReadLine());
                    List<string> games = PlayerController.GetAllGamesAPlayerHas(playerId);
                    foreach (string gameName in games)
                    {
                        Console.WriteLine(gameName);
                    }
                    break;
                case 7:
                    //Изведи всички постижения, които има игра
                    Console.Write("Въведи ID на играта, за да видиш постиженията ѝ: ");
                    int gameId = int.Parse(Console.ReadLine());

                    List<string> achievementNames = GameController.GetAllAchievementsFromGame(gameId);
                    foreach (string achievement in achievementNames)
                    {
                        Console.WriteLine(achievement);
                    }
                    break;
                case 8:
                    //Изведи всички игри, които има компания
                    Console.Write("Въведи ID на компания, за да видиш всичките ѝ игри: ");
                    int gameCompanyId = int.Parse(Console.ReadLine());

                    List<string> gameNames = GameCompanyController.GetAllGamesFromGameCompany(gameCompanyId);
                    foreach (string gameName in gameNames)
                    {
                        Console.WriteLine(gameName);
                    }
                    break;
                case 9:
                    // Изведи всички постижения, които има играч
                    Console.Write("Въведи ID на играч, за да видиш всичките му постижения: ");
                    int playerId1 = int.Parse(Console.ReadLine());

                    List<string> achNames = PlayerController.GetAllAchievementsFromPlayer(playerId1);
                    foreach (string achievementName in achNames)
                    {
                        Console.WriteLine(achievementName);
                    }
                    break;
                case 10:
                    // Изведи всички постижения от всички компании
                    Console.Write("Въведи ID на компания, за да видиш всички нейни постижения: ");
                    int companyIdForAchievements = int.Parse(Console.ReadLine());

                    List<string> companyAchievements = GameCompanyController.GetAllAchievementsFromCompany(companyIdForAchievements);
                    foreach (string ach in companyAchievements)
                    {
                        Console.WriteLine(ach);
                    }
                    break;
                case 11:
                    // Изведи всички играчи от всички компании
                    Console.Write("Въведи ID на компания, за да видиш всички нейни играчи: ");
                    int companyIdForPlayers = int.Parse(Console.ReadLine());

                    List<string> companyPlayers = GameCompanyController.GetAllPlayersFromCompany(companyIdForPlayers);
                    foreach (string playerName in companyPlayers)
                    {
                        Console.WriteLine(playerName);
                    }
                    break;
            }
        }
    }
}
