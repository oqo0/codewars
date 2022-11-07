// https://www.codewars.com/kata/5dae2599a8f7d90025d2f15f/

public class Kata
{
  public static bool ConsecutiveDucks(int n) => (n & (n - 1)) != 0;
}