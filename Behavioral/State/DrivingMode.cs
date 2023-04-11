using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.State
{
    public class DrivingMode : Mode
    {
        public object getDirection()
        {
            Console.WriteLine("Calculating direction (driving)");
            return 1;
        }

        public object getEta()
        {
            Console.WriteLine("Calculating ETA (driving)");
            return 1;
        }
    }
}
