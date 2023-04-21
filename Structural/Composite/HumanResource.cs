using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Composite
{
    internal class HumanResource : Resource
    {
        public void Deploy()
        {
            Console.WriteLine("Deploying a Human resource");
        }
    }
}
