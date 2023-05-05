using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.Builder
{
    public class TextDocumentBuilder : DocumentConversionBuilder
    {
        private StringBuilder _builder;

        public TextDocumentBuilder()
        {
            _builder = new StringBuilder();
        }
        public void AddElement(Element element)
        {

            if (element.GetType() == typeof(TextElement) ){
                var text = ((TextElement)element).GetContent();
                _builder.Append(text);

            }
        }

        public void GetFinaleDocument(string filename)
        {
            Console.WriteLine("Text content is :");
            Console.WriteLine(_builder.ToString());
            File.WriteAllText(filename, _builder.ToString());

        }
    }
}
