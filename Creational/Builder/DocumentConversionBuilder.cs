using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.Builder
{
    public interface DocumentConversionBuilder
    {
        void AddElement(Element element);
        void GetFinaleDocument(string filename);
    }
}
