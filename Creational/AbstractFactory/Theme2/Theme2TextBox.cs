using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.AbstractFactory.Theme2
{
    public class Theme2TextBox:TextBox
    {
        public void render()
        {
            Console.WriteLine("rendering a theme2 textbox");
        }
    }
}
