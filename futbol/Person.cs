namespace futbol
{
    public class Person
    {
        public string name { get; set; }
        public string lastName { get; set; }
        public int age { get; set; }
        public double height { get; set; }
        public double weight { get; set; }

        public Person(string name, string lastName, int age, double height, double weight)
        {
            this.name = name;
            this.lastName = lastName;
            this.age = age;
            this.height = height;
            this.weight = weight;
        }

        public override string ToString()
        {
            return $"Persona: {name} {lastName} | Edad: {age} | Altura: {height} | Peso: {weight}";
        }
    }
}
