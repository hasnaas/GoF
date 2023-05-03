using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Decorator
{
    internal class MainArtifact : Artifact
    {
    
        private Artifact _artifact;

        public MainArtifact(Artifact a)
        {
            
            _artifact = a;
        }


        public  string render()
        {
            return _artifact.render() + " MainIcon";
        }
    }
}
