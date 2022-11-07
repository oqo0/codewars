// https://www.codewars.com/kata/55d24f55d7dd296eb9000030/

using System.Linq;

public static class Kata 
{
    public static int summation(int num)
    {
      return Enumerable.Range(1, num).Sum();
    }
}