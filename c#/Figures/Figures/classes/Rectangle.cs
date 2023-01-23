using System;

/// <summary>
/// Объект типа прямоугольник
/// </summary>
public class Rectangle : Figure
{
    double width;
    double height;

    public Rectangle(
        double rectangleWidth,
        double rectangleHeight
    )
    {
        Width = rectangleWidth;
        Height = rectangleHeight;
    }

    public double Width
    {
        get { return width; }
        set { width = value < 0 ? -value : value; }
    }

    public double Height
    {
        get { return height; }
        set { height = value < 0 ? -value : value; }
    }

    public override double Area()
    {
        return width * height;
    }

    public override double Perimeter()
    {
        return width * 2 + height * 2;
    }

    public override string ShapeName()
    {
        return "Прямоугольник";
    }
}