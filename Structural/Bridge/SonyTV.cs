using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Bridge
{
    public class SonyTV:TVdevice
    {
        public void SetChannel(int number)
        {
            Console.WriteLine("Setting channel " + number + " for sony tv");
        }

        public void TurnOff()
        {
            Console.WriteLine("Turning off sony tv");
        }

        public void TurnOn()
        {
            Console.WriteLine("Turning on sony tv");
        }
    }
}
