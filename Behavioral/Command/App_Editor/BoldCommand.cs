using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Command
{
    public class BoldCommand : UndoableCommand
    {
        private HTMLdocument document;
        private string previousContent;
        private History history;

        public BoldCommand(HTMLdocument doc,History hist)
        {
            document = doc;
            history = hist;
        }
        public void execute()
        {
            previousContent = document.Content;
            document.MakeBold();
        }

        public void unexecute()
        {
            document.Content = previousContent;
        }
    }
}
