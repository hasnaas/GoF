﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.Builder.Html
{
    public class HtmlDocument
    {
        private List<HtmlElement> elements = new List<HtmlElement>();

        public void add(HtmlElement element)
        {
            elements.Add(element);
        }


        public override string ToString()
        {
            var builder = new StringBuilder();
            builder.Append("<html>");
            foreach (var element in elements)
                builder.Append(element.ToString());
            builder.Append("</html>");
            return builder.ToString();
        }
    }
}
