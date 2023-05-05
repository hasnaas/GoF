using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.AbstractFactory.Theme1
{
    public class Theme1WidgetFactory : WidgetFactory
    {
        public Button createButton()
        {
            return new Theme1Button();
        }

        public TextBox createTextBox()
        {
            return new Theme1TextBox();
        }
    }
}
