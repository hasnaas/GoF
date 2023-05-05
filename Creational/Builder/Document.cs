using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.Builder
{
    public class Document
    {
        private List<Element> elements = new List<Element>();

        public void Add(Element element)
        {
            elements.Add(element);
        }

        public void Export(DocumentConversionBuilder cb, string filename)
        {
            foreach(var element in elements)
                cb.AddElement(element);

            cb.GetFinaleDocument(filename);
        }
    }
}
