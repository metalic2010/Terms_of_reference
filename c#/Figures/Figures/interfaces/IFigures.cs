public interface IFigures
{
    /// <summary>
    /// Метод расчёта площади объекта
    /// </summary>
    /// <returns>
    /// Возвращает вещественное число double
    /// </returns>
    double Area();

    /// <summary>
    /// Метод расчёта периметра объекта
    /// </summary>
    /// <returns>
    /// Возвращает вещественное число double
    /// </returns>
    double Perimeter();

    /// <summary>
    /// Метод выводит имя объекта
    /// </summary>
    /// <returns>
    /// Возвращает имя объекта в виде строки
    /// </returns>
    string ShapeName();

    /// <summary>
    /// Выводит консолидированную в строку информацию об объекте
    /// </summary>
    /// <returns>
    /// Возвращает строку с информацией об объекте
    /// </returns>
    string ShowInfo();
}
