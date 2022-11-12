// https://www.codewars.com/kata/55f1614853ddee8bd4000014/

public class SameNbDivisors
{
  public static int CountPairsInt(int diff, long nMax) 
  {
    int count = 0;
    
    for (int i = 1, j = diff + 1; j < nMax; i++, j++)
      if (CountDivisors(i) == CountDivisors(j)) count++;
    
    return count;
  }
  private static int CountDivisors(int n)
  {
    int count = 0;
    
    for (int i = 1; i * i <= n; i++)
    {
      if (n % i == 0)
      {
        count++;
        if (i * i != n) count++;
      }
    }
    
    return count;
  }
}