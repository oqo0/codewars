// https://www.codewars.com/kata/56747fd5cb988479af000028/

public class Kata
{
  public static string GetMiddle(string s)
  {
    int len = s.Length;
    
    return len % 2 == 0
      ? s.Substring(len / 2 - 1, 2)
      : s.Substring(len / 2, 1);
  }
}