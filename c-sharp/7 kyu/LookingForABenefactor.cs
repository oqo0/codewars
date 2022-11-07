// https://www.codewars.com/kata/569b5cec755dd3534d00000f/

using System;
using System.Linq;

public class NewAverage
{
  public static long NewAvg(double[] arr, double navg)
  {
    long res = Convert.ToInt64(Math.Ceiling(navg * (arr.Length + 1) - arr.Sum()));
    
    if (res < 0)
      throw new ArgumentException();
    
    return res;
  }
}