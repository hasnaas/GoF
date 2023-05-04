using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.Prototype
{
    public class Text : Component
    {
        private string Content;

        public Text(string content)
        {
            Content = content;
        }

        public string getContent()
        {
            return Content;
        }
        public Component Clone()
        {
            Console.WriteLine("cloning text component");
            var newText = new Text(Content);
            return newText;
        }
    }
}
