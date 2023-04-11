using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.State
{
    public class TransitMode :Mode
    {
        public object getDirection()
        {
            Console.WriteLine("Calculating direction (transit)");
            return 3;
        }

        public object getEta()
        {
            Console.WriteLine("Calculating ETA (transit)");
            return 3;
        }
    }
}
