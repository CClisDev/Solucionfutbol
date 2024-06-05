using System.Collections.Generic;
using System.Text;

namespace futbol
{
    public class Team
    {
        private string name;
        private List<Player> players = new List<Player>();
        private int numberWinners = 0;
        private int numberDefeats = 0;
        private int numberDraws = 0;

        public string Name { get => name; set => name = value; }
        public List<Player> Players { get => players; set => players = value; }
        public int NumWinners { get => numberWinners; set => numberWinners = value; }
        public int NumDefeats { get => numberDefeats; set => numberDefeats = value; }
        public int NumDraws { get => numberDraws; set => numberDraws = value; }

        public Team(string name)
        { 
            this.name = name;
        }

        public void AddPlayer(Player player)
        {
            players.Add(player);
        }

        public void RemovePlayer(Player player)
        {
            players.Remove(player);
        }

        public string PlayerList() {
            StringBuilder listPlayers = new StringBuilder();

            foreach (Player player in players) {
                listPlayers.AppendLine(player.ToString());
            }

            return listPlayers.ToString();
        }

        public override string ToString()
        {
            return $"Nombre del equipo: {name} | Numero de jugadores: {players.Count} | Partidos Ganados: {numberWinners} | Partidos Perdidos: {numberDefeats} | Partidos en empate: {numberDraws}";
        }
    }
}
