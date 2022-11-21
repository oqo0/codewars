// https://www.codewars.com/kata/560b8d7106ede725dd0000e2/

using System;

public class BeforeAfterPrimes 
{
  public static long[] PrimeBefAft(long num)
  {
    var res = new long[2];
    
    int i = 0;
    while (res[0] == 0 || res[1] == 0)
    {
      i++;
      
      if (IsPrime(num - i) && res[0] == 0)
        res[0] = num - i;
      
      if (IsPrime(num + i) && res[1] == 0)
        res[1] = num + i;
    }
    
    return res;
  }
  private static bool IsPrime(long num)
  {
    if (num <= 1) return false;
    if (num == 2) return true;
    if (num % 2 == 0) return false;

    var boundary = (int)Math.Floor(Math.Sqrt(num));
    
    for (int i = 3; i <= boundary; i += 2)
        if (num % i == 0)
            return false;
    
    return true;
  }
}