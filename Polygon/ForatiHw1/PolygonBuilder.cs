namespace ForatiHw1;

public class PolygonBuilder
{
    private List<Point> _points = new List<Point>();

    public PolygonBuilder AddPoint(double x, double y)
    {
        _points.Add(new Point(x, y));
        return this;
    }

    public PolygonBuilder AddPointRange(List<Point> points)
    {
        _points.AddRange(points);
        return this;
    }

    public Polygon Build()
    {
        return new Polygon(_points);
    }
}
