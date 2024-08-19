namespace ForatiHw1;

public class AreaCalculator
{
    private readonly Polygon _polygon;

    public AreaCalculator(Polygon polygon)
    {
        _polygon = polygon;
    }

    public double CalculateArea()
    {
        var points = _polygon.GetPoints();
        double area = 0;

        int j = points.Count - 1;
        for (int i = 0; i < points.Count; i++)
        {
            area += (points[j].X + points[i].X) * (points[j].Y - points[i].Y);
            j = i;
        }

        return Math.Abs(area / 2.0);
    }
}
