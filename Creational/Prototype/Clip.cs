using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.Prototype
{
    public class Clip : Component
    {
        public Component Clone()
        {
            Console.WriteLine("cloning audio component");
            return new Clip();
        }
    }
}
