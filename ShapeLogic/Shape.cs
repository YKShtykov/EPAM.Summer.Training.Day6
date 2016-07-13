using System;

namespace ShapeLogic
{
  public abstract class Shape
  {
    public double CharacteristicSize { get; set; }
  }

  public abstract class Shape2D : Shape
  {
    public double Square { get; set; }
    public double Perimeter { get; set; }

    public Shape2D(double a)
    {
      CharacteristicSize = a;
    }

    public abstract double SquareCalculation();

    public abstract double PerimeterCalculation();
  }

  /// <summary>
  /// Square class, consists mehtods for calculating perimeter and square
  /// </summary>
  public class Square : Shape2D
  {
    public Square(double a):base(a) {}

    /// <summary>
    /// calculates perimeter
    /// </summary>
    /// <returns></returns>
    public override double PerimeterCalculation()
    {
      return 4 * CharacteristicSize;
    }

    /// <summary>
    /// Calculates square
    /// </summary>
    /// <returns></returns>
    public override double SquareCalculation()
    {
      return CharacteristicSize * CharacteristicSize;
    }
  }

  /// <summary>
  /// Circle class, consists mehtods for calculating perimeter and square
  /// </summary>
  public class Circle : Shape2D
  {
    public Circle(double diameter) : base(diameter) { }

    /// <summary>
    /// calculates perimeter
    /// </summary>
    /// <returns></returns>
    public override double PerimeterCalculation()
    {
      return Math.PI * CharacteristicSize;
    }

    /// <summary>
    /// Calculates square
    /// </summary>
    /// <returns></returns>
    public override double SquareCalculation()
    {
      return Math.PI * CharacteristicSize / 4;
    }  
  }

  /// <summary>
  /// Triangle class, consists mehtods for calculating perimeter and square
  /// </summary>
  public class Triangle : Shape2D
  {
    public double SecondCharactericticSize { get; set; }
    public double Angle { get; set; }

    public Triangle(double a, double b, double angle) : base(a)
    {
      SecondCharactericticSize = b;
      Angle = angle;
    }

    /// <summary>
    /// Calculates square
    /// </summary>
    /// <returns></returns>
    public override double SquareCalculation()
    {
      return 0.5 * CharacteristicSize * SecondCharactericticSize * Math.Sin(Angle);
    }

    /// <summary>
    /// calculates perimeter
    /// </summary>
    /// <returns></returns>
    public override double PerimeterCalculation()
    {
      return CharacteristicSize + SecondCharactericticSize + Math.Pow(Math.Pow(CharacteristicSize, 2)
        + Math.Pow(SecondCharactericticSize, 2) - 2 * CharacteristicSize * SecondCharactericticSize * Math.Cos(Angle), 0.5);
    }
  }

  /// <summary>
  /// Rectangle class, consists mehtods for calculating perimeter and square
  /// </summary>
  public class Rectangle : Shape2D
  {
    public double SecondCharactericticSize { get; set; }

    public Rectangle(double a, double b) : base(a)
    {
      SecondCharactericticSize = b;
    }

    /// <summary>
    /// calculates perimeter
    /// </summary>
    /// <returns></returns>
    public override double PerimeterCalculation()
    {
      return 2 * CharacteristicSize + 2 * SecondCharactericticSize;
    }

    /// <summary>
    /// Calculates square
    /// </summary>
    /// <returns></returns>
    public override double SquareCalculation()
    {
      return CharacteristicSize * SecondCharactericticSize;
    }
  }
}
