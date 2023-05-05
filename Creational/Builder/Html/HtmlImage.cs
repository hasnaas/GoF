using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.Builder.Html
{
    public class HtmlImage : HtmlElement
    {
        private string _source;

        public HtmlImage(string source)
        {
            _source = source;
        }


        public override string ToString()
        {
            return "<img src=" + _source + " />";
        }
    }
}
