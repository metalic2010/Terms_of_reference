public class Colors : IColors
{
    string color;

    private IFigures figure;
    public IFigures Figures
    {
        get => figure;
        set => figure = value;
    }

    public Colors(
        string _color,
        IFigures _Figures
    )
    {
        color = _color;
        Figures = _Figures;
    }
    public string getColor() => color.ToLower();
}