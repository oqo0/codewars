// https://www.codewars.com/kata/55908aad6620c066bc00002a/

using System.Linq;
using System;

public static class Kata 
{
  public static bool XO(string input)
  {
    return input.Count(x => Char.ToLower(x) == 'x') == input.Count(x => Char.ToLower(x) == 'o');
  }
}