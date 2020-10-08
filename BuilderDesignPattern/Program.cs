using System;

namespace BuilderDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var builder = new HtmlBuilder("ul");
            builder.AddChild("li", "hello");
            builder.AddChild("li", "world");
            Console.WriteLine(builder.ToString());
            
            var fluentBuilder = new HtmlFluentBuilder("ul");
            fluentBuilder
                .AddChild("li", "Fluent")
                .AddChild("li", "Builder");
            Console.WriteLine(fluentBuilder.ToString());
            
            var personBuilder = new PersonJobBuilder();
            personBuilder.Called("Robert");
        }
    }
}