using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Command
{
    public class CompositeCommand:Command
    {
        private List<Command> _commands=new List<Command>();

        public void  AddCommand(Command cmd)
        {
            _commands.Add(cmd);
        }

        public void execute()
        {
            foreach (var c in _commands)
                c.execute();
        }
    }
}
