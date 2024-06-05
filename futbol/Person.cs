namespace futbol
{
    public class Person
    {
        private string name ;
        private string lastName ;
        private int age ;
        private double height ;
        private double weight;

        public string Name { get => name; set => name=value; }
        public string LastName { get => lastName; set => lastName=value; }
        public int Age { get => age; set => age=value; }
        public double Height { get => height; set => height=value; }
        public double Weight { get => weight; set => weight=value; }

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
