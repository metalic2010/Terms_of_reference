
var figures = new List<Figure> {
            new Triangle(9, 9, 9),
            new Square(20),
            new Rectangle(5, 6),
            new Rectangle(10, 16),
            new Circle(20)
        };

foreach (Figure f in figures)
{
    Console.WriteLine("\n=======================");
    Console.WriteLine($"Информация об объекте:\n{f.ShowInfo()}");
    Console.WriteLine("=======================\n");
}

var colorFigures = new List<Colors> {
            new Colors("красный", new Triangle(9, 9, 9)),
            new Colors("белый", new Square(20)),
            new Colors("чёрный", new Rectangle(5, 6)),
            new Colors("жёлтый", new Rectangle(10, 16)),
            new Colors("зелёный", new Circle(20))
        };

foreach (Colors cf in colorFigures)
{
    Console.WriteLine("\n=======================");
    Console.WriteLine($"Информация об объекте:\n{cf.Figures.ShowInfo()}");
    Console.WriteLine($"Цвет: {cf.getColor()}");
    Console.WriteLine("=======================\n");
}

Console.WriteLine("Нажмите любую клавишу для завершения работы программы...");
Console.ReadKey();