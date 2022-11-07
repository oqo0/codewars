// https://www.codewars.com/kata/56cd44e1aa4ac7879200010b/

using System;
using System.Linq;

public static class StringExtensions
{
  public static bool IsUpperCase(this string text)
  {
    return text.All(x => Char.IsUpper(x) || !Char.IsLetter(x));
  }
}