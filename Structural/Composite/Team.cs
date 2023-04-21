using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Composite
{
    public class Team : Resource
    {
        private List<Resource> resources = new List<Resource>();

        public void Add(Resource r)
        {
            resources.Add(r);
        }

        public void Deploy()
        {
            foreach (Resource r in resources)
                r.Deploy();
        }
    }
}
