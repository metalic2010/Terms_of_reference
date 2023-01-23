public class CircleTests
{
    [Fact]
    public void Area_20_Circle()
    {
        Circle shape = new Circle(20);

        Assert.Equal(1256.6370614359173, shape.Area());
    }

    [Fact]
    public void CheckColor_red_Circle()
    {
        Colors colorShape = new Colors("красный", new Circle(20));

        Assert.Equal("красный", colorShape.getColor());
    }

    [Fact]
    public void CheckColorShape_Area20_Circlee()
    {
        Colors colorShape = new Colors("красный", new Circle(20));

        Assert.Equal(1256.6370614359173, colorShape.Figures.Area());
    }
}