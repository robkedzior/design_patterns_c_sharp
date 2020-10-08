using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderDesignPattern
{
    public class HtmlFluentBuilder
    {
        private readonly string rootName;
        HtmlElement root = new HtmlElement();

        public HtmlFluentBuilder(string rootName)
        {
            this.rootName = rootName;
            root.Name = rootName;
        }

        public HtmlFluentBuilder AddChild(string childName, string childText)
        {
            var e = new HtmlElement(childName, childText);
            root.Elements.Add(e);
            return this;
        }

        public override string ToString()
        {
            return root.ToString();
        }

        public void Clear()
        {
            root = new HtmlElement(){Name = rootName};
        }
    }
}