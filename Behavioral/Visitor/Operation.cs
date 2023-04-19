using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Visitor
{
    public interface Operation
    {
        void Apply(HeadingNode heading);
        void Apply(AnchorNode anchor);
    }
}
