using System;

public class Rectangle
{
    public double Height { get; set; }
    public double Wight { get; set; }
}
public class Circle
{
    public double Radius { get; set; }
}
public class AreaCalculator
{
    public double TotalArea(object[] arrObjects)
    {
        double area = 0;
        Rectangle objRectangle;
        Circle objCircle;
        foreach (var obj in arrObjects)
        {
            if (obj is Rectangle)
            {
                area += obj.Height * obj.Width;
            }
            else
            {
                objCircle = (Circle)obj;
                area += objCircle.Radius * objCircle.Radius * Math.PI;
            }
        }
        return area;
    }
}
