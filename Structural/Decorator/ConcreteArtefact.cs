using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Decorator
{
    public class ConcreteArtefact : Artifact
    {
        private string _name;

        public ConcreteArtefact(string name)
        {
            _name = name;
        }

        public string render()
        {
            return _name;
        }
    }
}
