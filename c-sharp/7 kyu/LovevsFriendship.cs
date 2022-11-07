// https://www.codewars.com/kata/59706036f6e5d1e22d000016/

using System.Linq;

public static class Kata
{
  public static int WordsToMarks(string str)
  {
    return str.Sum(x => x - 96);
  }
}