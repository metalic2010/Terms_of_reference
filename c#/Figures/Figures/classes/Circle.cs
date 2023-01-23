using System;

/// <summary>
/// Объект типа круг
/// </summary>
public class Circle : Figure
{
    double radius;

    public Circle(
        double CircleRadius
    )
    {
        Radius = CircleRadius;
    }

    public double Radius
    {
        get { return radius; }
        set { radius = value < 0 ? -value : value; }
    }

    public override double Area()
    {
        return Math.PI * Math.Pow(radius, 2);
    }

    public override double Perimeter()
    {
        return (radius * 2) * Math.PI;
    }

    public override string ShapeName()
    {
        return "Круг";
    }
}