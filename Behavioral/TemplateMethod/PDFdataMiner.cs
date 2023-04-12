using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.TemplateMethod
{
    public class PDFdataMiner : DataMiner
    {
        protected override void ExtractData(string path)
        {
            Console.WriteLine("extracting data from PDF file");
        }

        protected override void OpenFile(string path)
        {
            Console.WriteLine("Opening PDF file");
        }

        protected override void ParseData(string path)
        {
            Console.WriteLine("Parsing Data from PDF file");
        }
    }
}
