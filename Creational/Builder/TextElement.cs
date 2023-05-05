using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.Builder
{
    public class TextElement:Element
    {
        private string _content;

        public TextElement(string content)
        {
            _content = content;
        }

        public string GetContent()
        {
            return _content;
        }
    }
}
