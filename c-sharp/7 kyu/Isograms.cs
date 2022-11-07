// https://www.codewars.com/kata/54ba84be607a92aa900000f1/

using System.Linq;

public class Kata
{
  public static bool IsIsogram(string str) 
  {
    return str.ToLower().Distinct().Count()==str.Length;
  }
}