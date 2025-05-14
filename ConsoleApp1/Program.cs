using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SteamContext
            // replica na steam
            // players
            // creators
            // games
            // achievements
            while (true)
            {
                ShowWAT();
                string input = Console.ReadLine();

            }
        }

        static void ShowWAT()
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

        static void InputIt()
        {
            using (StreamReader reader = new StreamReader("input.txt"))
            {
                string line;
                int i = 0;
                while ((line = reader.ReadLine()) != null)
                {
                    if (i < 5)
                    {

                    }
                    i++;
                }
            }

        }
    }
}
