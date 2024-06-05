namespace futbol
{
    public class Player : Person
    {
        public int numberGoals { get; set; }
        public int numberAssists { get; set; }
        public int numberRedCards { get; set; }
        public int numberYellowCards { get; set; }
        public int dorsalNumber { get; set; }
        public string position { get; set; }

        public Player(string position, int dorsalNumber, string name, string lastName, int age, double height, double weight)
                        : base(name, lastName, age, height, weight)
        {
            this.dorsalNumber = dorsalNumber;
            this.numberGoals = 0;
            this.numberAssists = 0;
            this.numberRedCards = 0;
            this.numberYellowCards = 0;
        }

        public override string ToString()
        {
            return $"{base.ToString()} | Posición: {position} | Dorsal: {dorsalNumber} | Goles: {numberGoals} | Asistencias: {numberAssists} | Tarjetas amarillas: {numberYellowCards} | Tajetas Rojas: {numberRedCards} |";
        }
    }
}
