using Data;
using Data.Entities;
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
    }
}
