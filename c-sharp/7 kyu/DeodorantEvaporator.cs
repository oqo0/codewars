// https://www.codewars.com/kata/5506b230a11c0aeab3000c1f/

using System;

public class Evaporator
{ 
  public static int evaporator(double content, double evap_per_day, double threshold)
  {
    return (int)Math.Ceiling(Math.Log(threshold / 100.0) / Math.Log(1.0 - evap_per_day / 100.0));
  }
}