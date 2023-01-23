using System;

/// <summary>
/// Объект типа треугольник
/// </summary>
public class Triangle : Figure
{
    double sideA, sideB, sideC;

    public Triangle(
        double triangleSideA,
        double triangleSideB,
        double triangleSideC
    )
    {
        SideA = triangleSideA;
        SideB = triangleSideB;
        SideC = triangleSideC;
    }

    public double SideA
    {
        get { return sideA; }
        set { sideA = value < 0 ? -value : value; }
    }

    public double SideB
    {
        get { return sideB; }
        set { sideB = value < 0 ? -value : value; }
    }

    public double SideC
    {
        get { return sideC; }
        set { sideC = value < 0 ? -value : value; }
    }

    public override double Area()
    {
        double semPer = (sideA + sideB + sideC) / 2;
        return Math.Sqrt(semPer * (semPer - sideA) * (semPer - sideB) * (semPer - sideC));
    }

    public override double Perimeter()
    {
        return sideA + sideB + sideC;
    }

    public override string ShapeName()
    {
        return "Треугольник";
    }

    /// <summary>
    /// Метод проверки является ли треугольник прямоугольным
    /// </summary>
    /// <returns>
    /// Возвращает true или false
    /// "Этот треугольник прямоугольный" - true
    /// "Этот треугольник не прямоугольный" - false
    /// </returns>
    public bool Check_RightOrNorTriangle()
    {
        return ((SideA * SideA + SideB * SideB == SideC * SideC)
            || (SideA * SideA + SideC * SideC == SideB * SideB)
            || (SideC * SideC + SideB * SideB == SideA * SideA)
            );
    }
}