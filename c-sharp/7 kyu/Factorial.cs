// https://www.codewars.com/kata/57a049e253ba33ac5e000212/

namespace Solution
{
  public static class Program
  {
    public static ulong Factorial(ulong n)
    {
      return n > 1 ? n * Factorial(n - 1) : 1;
    }
  }
}