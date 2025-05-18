using Data.Entities;
using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public static class CreatorController
    {
        public static List<string> DisplayAllCreators()
        {
            SteamContext context = new SteamContext();
            List<string> creatorNames = new List<string>();

            foreach (Creator creator in context.Creators)
            {
                creatorNames.Add(creator.Name);
            }

            return creatorNames;
        }
    }
}
