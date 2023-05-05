using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.AbstractFactory.Theme2
{
    public class Theme2WidgetFactory : WidgetFactory
    {
        public Button createButton()
        {
            return new Them2Button();
        }

        public TextBox createTextBox()
        {
            return new Theme2TextBox();
        }
    }
}
