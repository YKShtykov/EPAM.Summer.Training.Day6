using System;
using NUnit.Framework;
using ShapeLogic;

namespace ShapeTests
{
  /// <summary>
  /// Test class For shapes
  /// </summary>
  [TestFixture]
  public class ShapeTest
  {
    /// <summary>
    /// tests square of square
    /// </summary>
    [Test]
    public void SquareTest()
    {
      Square s = new Square(2);

      Assert.AreEqual(s.SquareCalculation(), 4);
    }
    
    /// <summary>
    /// Tests perimeter of square
    /// </summary>
    [Test]
    public void SquarePerimeterTest()
    {
      Square s = new Square(2);

      Assert.AreEqual(s.PerimeterCalculation(), 8);
    }

    /// <summary>
    /// Tests square of rectangle
    /// </summary
    [Test]
    public void RectTest()
    {
      Rectangle r = new Rectangle(4, 7); 

      Assert.AreEqual(r.SquareCalculation(), 28);
    }

    /// <summary>
    /// Tests perimeter of rectangle
    /// </summary
    [Test]
    public void RectPerimeterTest()
    {
      Rectangle r = new Rectangle(4, 7);

      Assert.AreEqual(r.PerimeterCalculation(), 22);
    }

    /// <summary>
    /// Tests square of circle
    /// </summary
    [Test]
    public void CircleTest()
    {
      Circle c = new Circle(5);

      Assert.AreEqual(c.SquareCalculation(), Math.PI*5/4);
    }

    /// <summary>
    /// Tests perimeter of circle
    /// </summary
    [Test]
    public void CirclePerimeterTest()
    {
      Circle c = new Circle(5);

      Assert.AreEqual(c.PerimeterCalculation(), 5*Math.PI);
    }
    /// <summary>
    /// Tests square of triangle
    /// </summary
    [Test]
    public void TriangleTest()
    {
      Triangle t = new Triangle(1, 2, 1.5708);

      Assert.AreEqual(t.SquareCalculation(), 1, 0.01);
    }

    /// <summary>
    /// Tests perimeter of triangle
    /// </summary
    [Test]
    public void TrianglePerimeterTest()
    {
      Triangle t = new Triangle(3, 4, 1.5708);

      Assert.AreEqual(t.PerimeterCalculation(), 3+4+5, 0.01);
    }
  }
}
