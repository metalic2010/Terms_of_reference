using System;

public abstract class Figure : IFigures
{
    public abstract double Area();
    public abstract double Perimeter();
    public abstract string ShapeName();

    public string ShowInfo()
    {
        return
            $"Название фигуры: {Convert.ToString(ShapeName())}\n" +
            $"Площадь: {Convert.ToString(Area())}\n" +
            $"Периметр: {Perimeter()}";
    }
}