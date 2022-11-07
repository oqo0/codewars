// https://www.codewars.com/kata/5259b20d6021e9e14c0010d4/

using System;
using System.Linq;

public static class Kata
{
  public static string ReverseWords(string str)
  {
    return String.Join(' ', str.Split(' ').Select(x => new string(x.Reverse().ToArray())));
  }
}