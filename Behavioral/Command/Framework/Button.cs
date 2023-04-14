using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Command
{
    public class Button
    {
        public string Label { get; set; }
        private Command _command;

        public Button(Command command)
        {
            _command = command;
        }

        public void Click()
        {
            _command.execute();
        }
    }
}
