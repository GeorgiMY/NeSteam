using Core;
using Data;
using Data.Entities;

namespace ConsoleApp
{
    internal class Program
    {

        public void Main(string[] args)
        {
            // replica na steam
            // players
            // creators
            // games
            // achievements
            // game copmanies

            while (true)
            {
                ShowWAT();
                string input = Console.ReadLine();
            }
        }

        public void ShowWAT()
        {
            Console.WriteLine("1. Изведи всички NeSteam играчи");
            Console.WriteLine("2. Изведи всички NeSteam създатели");
            Console.WriteLine("3. Изведи всички NeSteam игри");
            Console.WriteLine("4. Изведи всички NeSteam постижения");
            Console.WriteLine("5. Изведи всички NeSteam копмании за игри");
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("6. Изведи всички игри, които има играч");
            Console.WriteLine("7. Изведи всички постижения, които има игра");
            Console.WriteLine("8. Изведи всички игри, които има компания");
            Console.WriteLine("9. Изведи ");
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("10. Изведи конкретни постижения от всички компании");
            Console.WriteLine("11. Изведи конкретни играчи от всички компании");
        }

        public void WhatsTheCase(int command)
        {
            switch (command)
            {
                case 1:
                    // Изведи всички NeSteam играчи
                    PlayerController.DisplayAllPlayers();
                    break;
                case 2:
                    // Изведи всички NeSteam създатели
                    CreatorController.DisplayAllCreators();
                    break;
                case 3:
                    // Изведи всички NeSteam игри
                    GameController.DisplayAllGames();
                    break;
                case 4:
                    // Изведи всички NeSteam постижения
                    AchievementController.DisplayAllAchievements();
                    break;
                case 5:
                    // Изведи всички NeSteam компании за игри
                    GameCompanyController.DisplayAllGameCompanies();
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
                    break;
                default:
                    break;
            }
        }
    }
}
