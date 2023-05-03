using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Decorator
{
    public class Editor
    {
        public void OpenProject(string path)
        {
            Artifact[] items =
                    {
            new HasErrorArtifcat(new MainArtifact(new ConcreteArtefact("MainClass"))),
            new ConcreteArtefact("Demo"),
            new HasErrorArtifcat(new ConcreteArtefact("EmailClient")),
            new ConcreteArtefact("EmailProvider")
        };
            foreach(var a in items)
            {
                Console.WriteLine(a.render());
            }
        }
        
    }
}
