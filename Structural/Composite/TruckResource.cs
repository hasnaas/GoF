using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Composite
{
    public class TruckResource : Resource
    {
        public void Deploy()
        {
            Console.WriteLine("Deploying a Truck resource ...");
        }
    }
}
