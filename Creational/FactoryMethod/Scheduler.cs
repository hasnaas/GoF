using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.FactoryMethod
{
    public abstract class Scheduler
    {
        private Calendar _calendar;

        public Scheduler()
        {
            _calendar = GetCalendar();
        }
        public void Schedule(Event evt) {
            var today = new DateTime();
            _calendar.AddEvent(evt, today);
        }
        protected abstract Calendar GetCalendar();
    }
}
