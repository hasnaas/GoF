using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.Prototype
{
    public class Timeline
    {
        private List<Component> components = new List<Component> ();

        public void Add(Component component)
        {
            components.Add(component);
        }
    }
}
