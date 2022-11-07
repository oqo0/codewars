// https://www.codewars.com/kata/51c8991dee245d7ddf00000e/

using System;
using System.Linq;

public class Kata
{
  public static string ReverseWords(string str)
  {
    return String.Join(" ", str.Split(' ').Reverse());
  }
}