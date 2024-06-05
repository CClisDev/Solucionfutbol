using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace futbol
{
    internal class Team
    {
        string name;
        List<Player> players = new List<Player>();
        int NumWinners = 0;
        int NumDefeats = 0;
        int NumTies = 0;

        public string Name { get => name; set => name = value; }
        public List<Player> Players { get => players; set => players = value; }
        public int NumWinners1 { get => NumWinners; set => NumWinners = value; }
        public int NumDefeats1 { get => NumDefeats; set => NumDefeats = value; }
        public int NumTies1 { get => NumTies; set => NumTies = value; }

        public Team(string name) { 
            this.name = name;
        }

        public void AddPlayer(Player x)
        {
            players.Add(x);
        }

        public void RemovePlayer(Player x)
        {
            players.Remove(x);
        }

        public void PlayerList() {
            Console.WriteLine("Player list:");
            foreach (Player player in players) { 
                Console.WriteLine(player);
            }
        }
    }
}
