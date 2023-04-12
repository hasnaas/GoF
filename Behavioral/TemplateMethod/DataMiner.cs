using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.TemplateMethod
{
    public abstract class DataMiner
    {
        //the template
        public void MineFile(string path)
        {
            Console.WriteLine("Processing "+path);
            OpenFile(path);
            ExtractData(path);
            ParseData(path);
            AnalyseData();
            SendReport();
            CloseFile();
        }

        //the hooks
        protected void AnalyseData()
        {
            Console.WriteLine("Analysing extrated file data ...");
        }

        protected void SendReport()
        {
            Console.WriteLine("Sending report ...");
        }

        public void CloseFile()
        {
            Console.WriteLine("Closing file.");
        }
        protected abstract void OpenFile(string path);
        protected abstract void ExtractData(string path);

        protected abstract void ParseData(string path);


    }
}
