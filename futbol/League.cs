using System.Collections.Generic;
using System.Text;

namespace futbol
{
    public class League
    {
        private string leagueName;
        private List<Team> teams = new List<Team>();
        private List<Player> players = new List<Player>();

        public League(string leagueName)
        {
            this.leagueName=leagueName;

            teams.Add(new Team("Barcelona"));
            teams.Add(new Team("Real Madrid"));
            teams.Add(new Team("Atletico Madrid"));
            teams.Add(new Team("Sevilla"));
            teams.Add(new Team("Valencia"));
            teams.Add(new Team("Real Betis"));
            teams.Add(new Team("Villarreal"));
            teams.Add(new Team("Real Sociedad"));
            teams.Add(new Team("Athletic Club"));
        }

        public string LeagueName { get => leagueName; set => leagueName=value; }
        public List<Team> Teams { get => teams; set => teams=value; }
        public List<Player> Players { get => players; set => players=value; }


        //Añadir jugador
        

        //Eliminar un jugador

        //Listar todo Jugadores
        public string GetPlayerList()
        {
            StringBuilder listPlayers = new StringBuilder();

            foreach (var players in players)
            {
                listPlayers.AppendLine(players.ToString());
            }

            return listPlayers.ToString();
        }

        public string GetPlayersByTeam(Team team)
        {
            return teams.Find(t => t == team).PlayerList();
        }

        public string GetListTeams()
        {
            StringBuilder listTeams = new StringBuilder();

            foreach (var team in teams)
            {
                listTeams.AppendLine(team.ToString());
            }

            return listTeams.ToString();
        }
    }
}
