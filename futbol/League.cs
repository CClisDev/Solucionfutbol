﻿using System.Collections.Generic;
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

        public void AddPlayer(Team team, Player player)
        {
            team.AddPlayer(player); //Añadir el jugador en el equipo
            this.players.Add(player); // Añadir el jugador en la liga
        }

        public void RemovePlayer(Player player)
        {
            players.Remove(player);
            player.Team.RemovePlayer(player);
            teams.Find(t => t == player.Team).Players.Remove(player);
        }

        public string GetPlayersList()
        {
            StringBuilder listPlayers = new StringBuilder();

            int index = 0;

            foreach (var player in players)
            {
                listPlayers.AppendLine($"({index++}) Nombre: {player.Name} | Equipo: {player.Team.Name}");
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
            int index = 0;

            listTeams.AppendLine("");

            foreach (var team in teams)
            {
                listTeams.AppendLine($"({index++}) {team.Name}");
            }

            return listTeams.ToString();
        }

        
    }
}
