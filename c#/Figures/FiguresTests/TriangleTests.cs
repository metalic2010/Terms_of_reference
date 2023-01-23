public class TriangleTests
{
    [Fact]
    public void Area_999_Triangle()
    {
        Triangle shape = new Triangle(9, 9, 9);

        Assert.Equal(35.074028853269766, shape.Area());
    }

    [Fact]
    public void Area_202020_Triangle()
    {
        Triangle shape = new Triangle(20, 20, 20);

        Assert.Equal(173.20508075688772, shape.Area());
    }

    [Fact]
    public void CheckFalse_Right_OrNor_Triangle()
    {
        Triangle shape = new Triangle(20, 20, 20);

        Assert.Equal(false, shape.Check_RightOrNorTriangle());
    }

    [Fact]
    public void CheckTrue_Right_OrNor_Triangle()
    {
        Triangle shape = new Triangle(4, 5, 3);

        Assert.Equal(true, shape.Check_RightOrNorTriangle());
    }

}