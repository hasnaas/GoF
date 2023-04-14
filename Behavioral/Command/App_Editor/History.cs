using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Command
{
    public class History
    {
    private Stack<UndoableCommand> _commands=new Stack<UndoableCommand> ();

        public void Push(UndoableCommand cmd)
        {
            _commands.Push (cmd);
        }

        public UndoableCommand Pop()
        {
            return _commands.Pop ();
        }

        public int Size()
        {
            return _commands.Count ();
        }
    }
}
