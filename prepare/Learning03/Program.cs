using System;
// Making this change because push to github is all wrong and need to fix comment. 5-30-23
class Program
{
  static void Main(string[] args)
  {
    Console.WriteLine("Hello Learning03 World!");
  }
}

public class Fraction
{
  private int _top;
  private int _bottom;

  public Fraction()
  {
    _top = 1;
    _bottom = 1;
  }

  public Fraction(int wholeNumber)
  {
    _top = wholeNumber;
    _bottom = 1;
  }

  public Fraction(int top, int bottom)
  {
    _top = top;
    _bottom = bottom;
  }
  public double GetTop()
  {
    return _top;
  }

  public void SetTop(int top)
  {
    _top = top;
  }

  public int GetBottom()
  {
    return _bottom;
  }

  public void SetBottom(int bottom)
  {
    _bottom = bottom;
  }

  /*Fraction f1 = new Fraction();
  f1.SetTop(1);

  Console.WriteLine(f1.GetTop());*/


}
