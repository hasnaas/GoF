using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Flyweight
{
    public class Point
    {
        private int x;  // 4 bytes
        private int y;  // 4 bytes
        private PointIcon icon;

        public Point(int x, int y, PointIcon icon)
        {
            this.x = x;
            this.y = y;
            this.icon = icon;
        }

        public void draw()
        {
            Console.WriteLine($"{icon.getType()} at ({x}, {y})");
        }
    }
}
