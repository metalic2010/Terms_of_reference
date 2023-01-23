using System;

/// <summary>
/// Объект типа квадрат
/// </summary>
public class Square : Figure
{
    double side;

    public Square(
        double squareSide
    )
    {
        Side = squareSide;
    }

    public double Side
    {
        get { return side; }
        set { side = value < 0 ? -value : value; }
    }

    public override double Area()
    {
        return side * side;
    }

    public override double Perimeter()
    {
        return side * 4;
    }

    public override string ShapeName()
    {
        return "Квадрат";
    }
}