using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.State
{
    public class WalkingMode :Mode
    {
        public object getDirection()
        {
            Console.WriteLine("Calculating direction (walking)");
            return 4 ;
        }

        public object getEta()
        {
            Console.WriteLine("Calculating ETA (walking)");
            return 4;
        }
    }
}
