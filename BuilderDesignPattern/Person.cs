namespace BuilderDesignPattern
{
    public class Person
    {
        public string ToString()
        {
            return $"{nameof(Name)}: {Name}, {nameof(Position)}: {Position}";
        }

        public string Name { get; set; }
        public string Position { get; set; }
    }
}