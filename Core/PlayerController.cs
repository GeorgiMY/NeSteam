using Data;
using Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace Core
{
    public static class PlayerController
    {
        public static List<string> DisplayAllPlayers()
        {
            SteamContext context = new SteamContext();
            List<string> players = context.Players.Select(p => p.Name).ToList();

            return players;
        }

        public static List<string> GetAllGamesAPlayerHas(int playerId)
        {
            SteamContext context = new SteamContext();

            List<string> gameNames = context.Achievements.Where(pg => pg.PlayerId == playerId).Include(pg => pg.GameInstance).Select(pg => pg.GameInstance.Name).ToList();

            return gameNames;
        }

        public static List<string> GetAllAchievementsFromPlayer(int playerId)
        {
            SteamContext context = new SteamContext();

            List<string> achievements = context.Players.Where(p => p.PlayerId == playerId).SelectMany(p => p.Achievements).Select(a => a.Name).ToList();

            return achievements;
        }
    }
}
