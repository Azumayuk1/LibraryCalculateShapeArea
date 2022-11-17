namespace TestsShapeAreaLibrary;

public class Tests
{
    [Test]
    public void CheckCalculatingCircleArea()
    {
        Assert.That(
            LibraryCalculateShapeArea.CalculateShapeArea.CalculateCircleArea(5, 1),
            Is.EqualTo(78.5)
        );

        Assert.That(
            LibraryCalculateShapeArea.CalculateShapeArea.CalculateCircleArea(0, 1),
            Is.EqualTo(0)
        );
    }

    [Test]
    public void CheckCalculatingTriangleArea()
    {
        Assert.That(
            LibraryCalculateShapeArea.CalculateShapeArea.CalculateTriangleArea(3, 4, 5, 1),
            Is.EqualTo(6.0)
            );
    }

    [Test]
    public void CheckIfTriangleIsRight()
    {
        Assert.AreEqual(LibraryCalculateShapeArea.CheckShapeAttributes.CheckIfTriangleIsRight(3, 4, 5), true);
    }
}