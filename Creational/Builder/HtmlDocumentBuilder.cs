using DesignPatterns.Creational.Builder.Html;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.Builder
{
    public class HtmlDocumentBuilder : DocumentConversionBuilder
    {
        HtmlDocument _document;



        public HtmlDocumentBuilder()
        {
            _document = new HtmlDocument();
        }
        public void AddElement(Element element)
        {
            if (element.GetType() == typeof(TextElement))
            {
                var text = ((TextElement)element).GetContent();
                _document.add(new HtmlParagraph(text));
            }
            else if (element.GetType() == typeof(ImageElement))
            {
                var source = ((ImageElement)element).GetSource();
                _document.add(new HtmlImage(source));
            }
        }

        public void GetFinaleDocument(string filename)
        {
            Console.WriteLine("html document content is :");
            Console.WriteLine(_document.ToString());
            File.WriteAllText(filename, _document.ToString());
        }
    }
}
