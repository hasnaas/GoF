using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Flyweight
{
    public class PointIcon
    {
        private PointType type; // 4 bytes
        private byte[] icon;    // 20 KB -> 20 MB

        public PointIcon(PointType type, byte[] icon)
        {
            this.type = type;
            this.icon = icon;
        }

        public PointType getType()
        {
            return type;
        }
    }
}
