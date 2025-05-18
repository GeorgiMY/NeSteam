using Data;
using Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public static class GameController
    {
        public static List<string> DisplayAllGames()
        {
            SteamContext context = new SteamContext();
            List<string> gameNames = new List<string>();

            foreach (Game game in context.Games)
            {
                gameNames.Add(game.Name);
            }

            return gameNames;
        }
    }
}
