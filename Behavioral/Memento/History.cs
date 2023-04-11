using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    internal class History
    {
        private Stack<DocumentState> states = new Stack<DocumentState>();

        public void Push(DocumentState ds)
        {
            states.Push(ds); 
   
        }

        public DocumentState Pop()
        {
            return states.Pop();
        }
    }
}
