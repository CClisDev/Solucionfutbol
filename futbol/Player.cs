namespace futbol
{
    public class Player : Person
    {
        private int numberGoals;
        private int numberAssists;
        private int numberRedCards;
        private int numberYellowCards;
        private int dorsalNumber;
        private string position;
        private Team team;

        public int NumberGoals { get => numberGoals; set => numberGoals=value; }
        public int NumberAssists { get => numberAssists; set => numberAssists=value; }
        public int NumberRedCards { get => numberRedCards; set => numberRedCards=value; }
        public int NumberYellowCards { get => numberYellowCards; set => numberYellowCards=value; }
        public int DorsalNumber { get => dorsalNumber; set => dorsalNumber=value; }
        public string Position { get => position; set => position=value; }
        public Team Team { get => team; set => team=value; }

        public Player(Team team,string position, int dorsalNumber, string name, string lastName, int age, double height, double weight)
                        : base(name, lastName, age, height, weight)
        {
            this.dorsalNumber = dorsalNumber;
            this.numberGoals = 0;
            this.numberAssists = 0;
            this.numberRedCards = 0;
            this.numberYellowCards = 0;
            this.team = team;
        }

        public override string ToString()
        {
            return $"{base.ToString()} | Posición: {position} | Dorsal: {dorsalNumber} | Goles: {numberGoals} | Asistencias: {numberAssists} | Tarjetas amarillas: {numberYellowCards} | Tajetas Rojas: {numberRedCards} |";
        }
    }
}
