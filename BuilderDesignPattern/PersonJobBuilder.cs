namespace BuilderDesignPattern
{
    public class PersonJobBuilder : PersonInfoBuilder
    {
        private PersonJobBuilder _personJobBuilder;

        public PersonJobBuilder WorksAsA(string position)
        {
            person.Position = position;
            return this;
        }
    }
}