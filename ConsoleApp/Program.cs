using Data;
using Data.Entities;

namespace ConsoleApp
{
    internal class Program
    {
        SteamContext context = new SteamContext();

        public void Main(string[] args)
        {
            // replica na steam
            // players
            // creators
            // games
            // achievements
            // game copmanies
            if (context.GameCompanies.Count() == 0) InputIt();

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
            Console.WriteLine("6. Премахни играч");
            Console.WriteLine("7. Премахни създател");
            Console.WriteLine("8. Премахни игра");
            Console.WriteLine("9. Премахни постижение");
            Console.WriteLine("10. Премахни компания за игри");
        }

        public void InputIt()
        {

            using (StreamReader reader = new StreamReader("input.txt"))
            {
                string line;
                int i = 0;
                while ((line = reader.ReadLine()) != null)
                {
                    // Първите 5 реда се добавят Achievement-и
                    if (i < 5)
                    {
                        context.Achievements.Add(new Achievement() { GameId = i, Name = line });
                    }
                    // Следващите 5 се добавят игри
                    else if (i < 10)
                    {
                        context.Games.Add(new Game() { Name = line });
                    }
                    else if (i < 15)
                    {
                        context.Creators.Add(new Creator() { Name = line });
                    }
                    else if (i < 20)
                    {
                        context.Players.Add(new Player() { Name = line, GameId = i - 15 });
                    }
                    else if (i < 25)
                    {
                        context.GameCompanies.Add(new GameCompany() { Name = line });
                    }
                    else if (i < 30)
                    {
                        int[] creatorsAndGames = line.Split(' ').Select(int.Parse).ToArray();
                        context.CreatorGames.Add(new CreatorGame() { CreatorId = creatorsAndGames[0], GameId = creatorsAndGames[1] });
                    }
                    else if (i < 35)
                    {
                        int[] gameCompanyCreator = line.Split(' ').Select(int.Parse).ToArray();
                        context.GameCompanyCreators.Add(new GameCompanyCreator() { GameCompanyId = gameCompanyCreator[0], CreatorId = gameCompanyCreator[1] });
                    }
                    i++;
                }
            }

        }

        public void WhatsTheCase(int command)
        {
            switch (command)
            {
                case 1:
                    // Изведи всички NeSteam играчи
                    foreach (Player player in context.Players)
                    {
                        Console.WriteLine(player.Name);
                    }
                    break;
                case 2:
                    // Изведи всички NeSteam създатели
                    foreach (Creator creator in context.Creators)
                    {
                        Console.WriteLine(creator.Name);
                    }
                    break;
                case 3:
                    // Изведи всички NeSteam игри
                    foreach (Game game in context.Games)
                    {
                        Console.WriteLine(game.Name);
                    }
                    break;
                case 4:
                    // Изведи всички NeSteam постижения
                    foreach (Achievement achievement in context.Achievements)
                    {
                        Console.WriteLine(achievement.Name);
                    }
                    break;
                case 5:
                    // Изведи всички NeSteam компании за игри
                    foreach (GameCompany gameCompany in context.GameCompanies)
                    {
                        Console.WriteLine(gameCompany.Name);
                    }
                    break;
                default:
                    break;
            }
        }
    }
}
