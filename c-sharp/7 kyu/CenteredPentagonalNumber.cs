// https://www.codewars.com/kata/5fb856190d5230001d48d721/

class Kata
{
  public static long Pentagonal(long n)
  {
    return n > 0 ? (5 * n * n - 5 * n + 2) / 2 : -1;
  }
}