using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Observer
{
    public class Subject
    {
        private List<Observer> _observers = new List<Observer>();

        public void AddObserver(Observer o)
        {
            _observers.Add(o);
        }

        public void RemoveObserver(Observer o)
        {
            _observers.Remove(o);
        }

        protected void NotifyObservers(object obj)
        {
            foreach (Observer o in _observers)
                o.Update();
        }
    }
}
