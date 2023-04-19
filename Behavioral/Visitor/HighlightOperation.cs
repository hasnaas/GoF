using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Visitor
{
    internal class HighlightOperation : Operation
    {
        public void Apply(HeadingNode heading)
        {
            Console.WriteLine("Highlighted heading");
        }

        public void Apply(AnchorNode anchor)
        {
            Console.WriteLine("Highlighted anchor");
        }
    }
}
