using Data.Entities;
using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public static class Inputs
    {
        public static void InputIt()
        {
            SteamContext context = new SteamContext();
            if (context.GameCompanies.Count() != 0) return;

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
                    // създатели
                    else if (i < 15)
                    {
                        context.Creators.Add(new Creator() { Name = line });
                    }
                    // играчи
                    else if (i < 20)
                    {
                        context.Players.Add(new Player() { Name = line });
                    }
                    // компании за игри
                    else if (i < 25)
                    {
                        context.GameCompanies.Add(new GameCompany() { Name = line });
                    }
                    // създатели и игри
                    else if (i < 30)
                    {
                        int[] creatorsAndGames = line.Split(' ').Select(int.Parse).ToArray();
                        context.CreatorGames.Add(new CreatorGame() { CreatorId = creatorsAndGames[0], GameId = creatorsAndGames[1] });
                    }
                    // компании и създатели
                    else if (i < 35)
                    {
                        int[] gameCompanyCreator = line.Split(' ').Select(int.Parse).ToArray();
                        context.GameCompanyCreators.Add(new GameCompanyCreator() { GameCompanyId = gameCompanyCreator[0], CreatorId = gameCompanyCreator[1] });
                    }
                    i++;
                }
            }

        }
    }
}
