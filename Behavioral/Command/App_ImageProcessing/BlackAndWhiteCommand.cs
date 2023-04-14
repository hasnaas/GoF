using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Command
{
    internal class BlackAndWhiteCommand : Command
    {
        public void execute()
        {
            Console.WriteLine("Applying black and white filter ...");
        }
    }
}
