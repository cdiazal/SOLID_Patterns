using System;

public class Rectangle
{
    public double Height { get; set; }
    public double Wight { get; set; }
}

public class AreaCalculator
{
    public double TotalArea(Rectangle[] arrRectangles)
    {
        double area;
        foreach (var objRectangle in arrRectangles)
        {
            area += objRectangle.Height * objRectangle.Width;
        }
        return area;
    }
}

