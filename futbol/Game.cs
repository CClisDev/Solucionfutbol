using System;

namespace futbol
{
    internal class Game
    {
        private DateTime date;
        private TimeSpan hour;
        private string place;
        private Team localTeam;// turno 0
        private Team visitTeam;// turno 1
        private int goalsLocalTeam = 0;
        private int goalsVisitTeam = 0;
        private Team teamWinner = null;

        public DateTime Date { get => date; set => date = value; }
        public TimeSpan Hour { get => hour; set => hour = value; }
        public string Place { get => place; set => place = value; }
        public int GoalsLocalTeam { get => goalsLocalTeam; set => goalsLocalTeam = value; }
        public int GoalsVisitTeam { get => goalsVisitTeam; set => goalsVisitTeam = value; }
        internal Team LocalTeam { get => localTeam; set => localTeam = value; }
        internal Team VisitTeam { get => visitTeam; set => visitTeam = value; }
        internal Team TeamWinner { get => teamWinner; set => teamWinner = value; }

        public Game(DateTime date, TimeSpan hour, string place, Team localTeam, Team visitTeam)
        {
            this.date = date;
            this.hour = hour;
            this.place = place;
            this.localTeam = localTeam;
            this.visitTeam = visitTeam;
        }


        public string ProcessGame()
        {
            Random random = new Random();

            goalsVisitTeam = random.Next(0, 10);
            goalsLocalTeam = random.Next(0, 10);

            if(CheckWinner() == null)
                return "Partido Empate";

            return $"Equipo ganador: {this.teamWinner.Name}";
        }

        public Team CheckWinner()
        {
            if (goalsLocalTeam > goalsVisitTeam)
            {
                this.teamWinner = LocalTeam;
                return LocalTeam;
            }
            else if(goalsLocalTeam < goalsVisitTeam)
            {
                this.teamWinner = visitTeam;
                return VisitTeam;
            }
            else
                return null;
        }

        public override string ToString()
        {
            return $@"
                    Game:
                    Date: {date},
                    Hour: {hour},
                    Place: {place},
                    Goals Local Team: {goalsLocalTeam},
                    Goals Visit Team: {goalsVisitTeam},
                    Winner: {(teamWinner == null ? "In process" : teamWinner.Name)}
                ";
        }
    }
}
