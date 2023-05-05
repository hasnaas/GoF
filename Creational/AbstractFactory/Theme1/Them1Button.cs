using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.AbstractFactory.Theme1
{
    public class Theme1Button : Button
    {
        public void render()
        {
            Console.WriteLine("rendering a theme1 button");
        }
    }
}
