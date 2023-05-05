using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.Builder
{
    public class ImageElement:Element
    {
        private string _source;
        public ImageElement(string source)
        {
            _source = source;
        }

        public string GetSource()
        {
            return _source;
        }
    }
}
