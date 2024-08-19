using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForatiHw1;

public class Polygon
{
    private readonly List<Point> _points;

    public Polygon(List<Point> points)
    {
        if (points == null || points.Count < 3)
            throw new ArgumentException("A polygon must have at least 3 points.");

        _points = points;
    }

    public List<Point> GetPoints()
    {
        return _points;
    }
}