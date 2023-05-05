using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.Builder.Html
{
    public class HtmlParagraph: HtmlElement
    {
        private string _text;

        public HtmlParagraph(string text)
        {
            _text = text;
        }

  
    public override string ToString()
        {
            return "<p>"+_text+"</p>";
        }
    }
}
