using Data.Entities;
using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public static class AchievementController
    {
        public static List<string> DisplayAllAchievements()
        {
            SteamContext context = new SteamContext();
            List<string> achievementNames = new List<string>();

            foreach (Achievement achievement in context.Achievements)
            {
                achievementNames.Add(achievement.Name);
            }

            return achievementNames;
        }
    }
}
