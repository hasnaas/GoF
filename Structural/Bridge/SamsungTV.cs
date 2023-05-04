using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Bridge
{
    public class SamsungTV : TVdevice
    {
        public void SetChannel(int number)
        {
            Console.WriteLine("Setting channel "+number+" for samsung tv");
        }

        public void TurnOff()
        {
            Console.WriteLine("Turning off samsung tv");
        }

        public void TurnOn()
        {
            Console.WriteLine("Turning on samsung tv");
        }
    }
}
