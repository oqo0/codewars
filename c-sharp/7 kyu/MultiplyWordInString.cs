// https://www.codewars.com/kata/5ace2d9f307eb29430000092/

using System;
using System.Linq;

public class Kata
{
  public static string ModifyMultiply(string str, int loc, int num)
  {
    return String.Join('-', Enumerable.Repeat(str.Split(' ')[loc], num));
  }
}