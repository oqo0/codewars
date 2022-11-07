// https://www.codewars.com/kata/5d50e3914861a500121e1958/

using System;
using System.Linq;

public class Kata
{
  public static char AddLetters(char[] letters)
  {
    var val = letters.Sum(c => c - 96) % 26;
    return val == 0 ? 'z' : (char)(val + 96);
  }
}