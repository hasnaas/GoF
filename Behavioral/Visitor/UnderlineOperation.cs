using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Visitor
{
    internal class UnderlineOperation : Operation
    {
        public void Apply(HeadingNode heading)
        {
            Console.WriteLine("Underlined heading");
        }

        public void Apply(AnchorNode anchor)
        {
            Console.WriteLine("Underlined anchor");
        }
    }
}
