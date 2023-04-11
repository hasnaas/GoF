using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.State
{
    public class DirectionService
    {
        public Mode TravelMode { get; set; }

        public DirectionService(Mode mode)
        {
            TravelMode = mode;
        }
        public object getETA()
        {
            return TravelMode.getEta();
        }

        public object GetDirection()
        {
            return TravelMode.getDirection();
        }

    }
}
