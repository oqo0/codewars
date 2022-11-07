// https://www.codewars.com/kata/58e8cad9fd89ea0c6c000258/

using System.Text.RegularExpressions;

public class Dinglemouse
{
  public static int KookaCounter(string laughing) => Regex.Matches(laughing, "(Ha)+|(ha)+").Count;
}