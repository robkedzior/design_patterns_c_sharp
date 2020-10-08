namespace BuilderDesignPattern
{
    public class PersonInfoBuilder
    {
        private PersonInfoBuilder _personInfoBuilder;
        protected Person person = new Person();

        public PersonInfoBuilder Called(string name)
        {
            person.Name = name;
            return this;
        }
    }
}