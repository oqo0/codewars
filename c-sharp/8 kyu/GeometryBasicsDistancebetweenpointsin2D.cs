// https://www.codewars.com/kata/58dced7b702b805b200000be/

using System;

public class Kata
{
  public static double DistanceBetweenPoints(Point a, Point b)
  {
    double height = Math.Abs(a.X - b.X);
    double width = Math.Abs(a.Y - b.Y);
    return Math.Sqrt(height * height + width * width);
  }
}