// https://www.codewars.com/kata/5286b2e162056fd0cb000c20/

using System.Collections.Generic;

public class Kata
{
  public static string Collatz(int n)
  {
    var listRes = new List<int>() { n };
    
    while (n != 1)
    {
      if (n % 2 == 0)
        n /= 2;
      else
        n = 3 * n + 1;
      
      listRes.Add(n);
    }
    
    return string.Join("->", listRes);
  }
}