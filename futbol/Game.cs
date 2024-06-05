using System;

namespace futbol
{
    internal class Game
    {
        DateTime date;
        TimeSpan hour;
        string place;
        Team localTeam;// turno 0
        Team visitTeam;// turno 1
        int goalsLocalTeam = 0;
        int goalsVisitTeam = 0;
        Team teamWinner = null;

        public DateTime Date { get => date; set => date = value; }
        public TimeSpan Hour { get => hour; set => hour = value; }
        public string Place { get => place; set => place = value; }
        public int GoalsLocalTeam { get => goalsLocalTeam; set => goalsLocalTeam = value; }
        public int GoalsVisitTeam { get => goalsVisitTeam; set => goalsVisitTeam = value; }
        internal Team LocalTeam { get => localTeam; set => localTeam = value; }
        internal Team VisitTeam { get => visitTeam; set => visitTeam = value; }
        internal Team TeamWinner { get => teamWinner; set => teamWinner = value; }

        public Game(DateTime date, TimeSpan hour,string place,Team localTeam,Team visitTeam) {
            this.date = date;
            this.hour = hour;
            this.place = place;
            this.localTeam = localTeam;
            this.visitTeam = visitTeam;
        }

        public override string ToString() {
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

        public Team ProcessGame() {
            Random random = new Random();
            goalsVisitTeam = random.Next(0, 10);
            goalsLocalTeam = random.Next(0, 10);
            return CheckWinner(goalsVisitTeam, goalsLocalTeam);
        }

        public Team CheckWinner(int x,int y) {
            Team w = null;

            if (goalsLocalTeam > goalsVisitTeam)
            {
                w = LocalTeam;
            }
            else
            {
                w = VisitTeam;
            }
            return w;

        }
    }
}
