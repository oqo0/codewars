// https://www.codewars.com/kata/5aa736a455f906981800360d/

public class Kata
{
  public static bool Feast(string beast, string dish)
  {
    return beast[0] == dish[0] && beast[^1] == dish[^1];;
  }
}