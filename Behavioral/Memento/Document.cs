using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class Document
    {
        public string Content { get; set; }
        public string FontName { get; set; }

        public short FontSize { get; set; }

        public Document()
        {
            Content = "";
            FontName = "Arial";
            FontSize = 16;
        }

        public DocumentState SaveState()
        {
            return new DocumentState(Content, FontName, FontSize); 
        }

        public void RestoreState(DocumentState ds)
        {
            Content=ds.Content;
            FontName=ds.FontName;
            FontSize=ds.FontSize;
        }
        public override string ToString()
        {
            return "Document{" +
               "content='" + Content + '\'' +
               ", fontName='" + FontName + '\'' +
               ", fontSize=" + FontSize +
               '}';
        }
    }

    public class DocumentState
    {
        //readonly properties reflecting those of document class
        public string Content { get; }
        public string FontName { get; }
        public short FontSize { get; }

        public DocumentState(string content, string fontName, short fontSize)
        {
            Content = content;
            FontName = fontName;
            FontSize = fontSize;
        }

        private DocumentState GetState()
        {
            return this;
        }

    }
}
