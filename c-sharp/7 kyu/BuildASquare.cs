// https://www.codewars.com/kata/59a96d71dbe3b06c0200009c/

using System;
using System.Linq;

public static class Kata
{
  public static string GenerateShape(int n)
  {
    return String.Join('\n', Enumerable.Repeat(new string('+', n), n));
  }
}