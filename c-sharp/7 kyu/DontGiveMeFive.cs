// https://www.codewars.com/kata/5813d19765d81c592200001a/

using System.Linq;

public class Kata
{
  public static int DontGiveMeFive(int s, int e)
  {
    return Enumerable.Range(s, e - s + 1).Count(x => !x.ToString().Contains('5'));
  }
}