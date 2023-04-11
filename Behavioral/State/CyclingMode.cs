using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.State
{
    public  class CyclingMode :Mode
    {
        public object getDirection()
        {
            Console.WriteLine("Calculating direction (cycling)");
            return 2;
        }

        public object getEta()
        {
            Console.WriteLine("Calculating ETA (cycling)");
            return 2;
        }
    }
}
