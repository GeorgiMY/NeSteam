using Core;
using Data.Entities;

namespace NeSteam.WinFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            List<string> players = PlayerController.DisplayAllPlayers();
            foreach (string gameName in players)
            {
                listBox1.Items.Add(gameName);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            List<string> creators = CreatorController.DisplayAllCreators();
            foreach (string gameName in creators)
            {
                listBox1.Items.Add(gameName);
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            List<string> games = GameController.DisplayAllGames();
            foreach (string gameName in games)
            {
                listBox1.Items.Add(gameName);
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            List<string> achievements = AchievementController.DisplayAllAchievements();
            foreach (string gameName in achievements)
            {
                listBox1.Items.Add(gameName);
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            List<string> achievements = GameCompanyController.DisplayAllGameCompanies();
            foreach (string gameName in achievements)
            {
                listBox1.Items.Add(gameName);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            int playerId = int.Parse(textBox1.Text);
            List<string> games = PlayerController.GetAllGamesAPlayerHas(playerId);
            foreach (string gameName in games)
            {
                listBox1.Items.Add(gameName);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            int gameId = int.Parse(textBox2.Text);

            List<string> achievementNames = GameController.GetAllAchievementsFromGame(gameId);
            foreach (string achievement in achievementNames)
            {
                listBox1.Items.Add(achievement);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            int gameCompanyId = int.Parse(textBox3.Text);

            List<string> gameNames = GameCompanyController.GetAllGamesFromGameCompany(gameCompanyId);
            foreach (string gameName in gameNames)
            {
                listBox1.Items.Add(gameName);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            int playerId = int.Parse(textBox4.Text);

            List<string> achNames = PlayerController.GetAllAchievementsFromPlayer(playerId);
            foreach (string achievementName in achNames)
            {
                listBox1.Items.Add(achievementName);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            int companyIdForAchievements = int.Parse(textBox5.Text);

            List<string> companyAchievements = GameCompanyController.GetAllAchievementsFromCompany(companyIdForAchievements);
            foreach (string ach in companyAchievements)
            {
                listBox1.Items.Add(ach);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            int companyIdForPlayers = int.Parse(textBox1.Text);

            List<string> companyPlayers = GameCompanyController.GetAllPlayersFromCompany(companyIdForPlayers);
            foreach (string playerName in companyPlayers)
            {
                listBox1.Items.Add(playerName);
            }
        }
    }
}
