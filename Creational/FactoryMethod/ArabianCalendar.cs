using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.FactoryMethod
{
    internal class ArabianCalendar : Calendar
    {
        public void AddEvent(Event evt, DateTime date)
        {
            Console.WriteLine("adding an event to an arabian calendar");
        }
    }
}
