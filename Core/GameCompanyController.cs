using Data;
using Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public static class GameCompanyController
    {
        public static List<string> DisplayAllGameCompanies()
        {
            SteamContext context = new SteamContext();
            List<string> gameCompanyNames = new List<string>();

            foreach (GameCompany gameCompany in context.GameCompanies)
            {
                gameCompanyNames.Add(gameCompany.Name);
            }

            return gameCompanyNames;
        }

        public static List<string> GetAllGamesFromGameCompany(int companyId)
        {
            SteamContext context = new SteamContext();

            var gameNames = context.Games
                .Where(g => g.GameCompanyId == companyId)
                .Select(g => g.Name)
                .ToList();

            return gameNames;
        }

        public static List<string> GetAllAchievementsFromCompany(int companyId)
        {
            SteamContext context = new SteamContext();

            var achievementNames = context.Games
                .Where(g => g.GameCompanyId == companyId)
                .Include(g => g.Achievements)
                .SelectMany(g => g.Achievements)
                .Select(a => a.Name)
                .ToList();

            return achievementNames;
        }

        public static List<string> GetAllPlayersFromCompany(int companyId)
        {
            SteamContext context = new SteamContext();

            var playerNames = context.Games
                .Where(g => g.GameCompanyId == companyId)
                .Include(g => g.Players)
                .SelectMany(g => g.Players)
                .Select(p => p.Name)
                .Distinct()
                .ToList();

            return playerNames;
        }
    }

}
