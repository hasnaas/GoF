using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.AbstractFactory
{
    public class ContactForm
    {
        public void render(WidgetFactory factory)
        {
            factory.createTextBox().render();
            factory.createButton().render();
        }
    }
}
