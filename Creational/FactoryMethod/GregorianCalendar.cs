using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.FactoryMethod
{
    internal class GregorianCalendar : Calendar
    {
        public void AddEvent(Event evt, DateTime date)
        {
            Console.WriteLine("adding an event to a gregorian calendar");
        }
    }
}
