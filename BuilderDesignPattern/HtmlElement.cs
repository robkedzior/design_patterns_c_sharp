using System.Collections.Generic;
using System.Text;

namespace BuilderDesignPattern
{
    public class HtmlElement
    {
        public const int IndentSize = 2;
        public string Name;
        public string Text;
        public readonly List<HtmlElement> Elements = new List<HtmlElement>();

        public HtmlElement()
        {
        }

        public HtmlElement(string name, string text)
        {
            Name = name;
            Text = text;
        }

        public override string ToString()
        {
            return ToStringImpl(0);
        }

        private string ToStringImpl(int indent)
        {
            var sb = new StringBuilder();
            var i = new string(' ', IndentSize * indent);
            sb.AppendLine($"{i}<{Name}>");
            if (!string.IsNullOrWhiteSpace(Text))
            {
                sb.Append(new string(' ', IndentSize * (indent + 1)));
                sb.AppendLine(Text);
            }

            foreach (var element in Elements)
            {
                sb.Append(element.ToStringImpl(indent + 1));
            }

            sb.AppendLine($"</{Name}>");

            return sb.ToString();
        }
    }
}