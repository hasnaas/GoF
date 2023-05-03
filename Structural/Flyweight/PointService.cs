using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Flyweight
{
    public class PointService
    {
        private PointIconFactory _iconFactory;

        public PointService(PointIconFactory iconFactory)
        {
            _iconFactory = iconFactory;
        }

        public List<Point> getPoints()
        {
            List<Point> points = new List<Point>();
            var point = new Point(1, 2, _iconFactory.getPointIcon(PointType.CAFE));
            points.Add(point);

            return points;
        }
    }
}
