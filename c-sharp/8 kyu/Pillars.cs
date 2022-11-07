// https://www.codewars.com/kata/5bb0c58f484fcd170700063d/

public static class Kata
{
  public static int Pillars(int n, int d, int w)
  {
    return n == 1 ? 0 : (n - 2) * w + (n - 1) * d * 100;
  }
}