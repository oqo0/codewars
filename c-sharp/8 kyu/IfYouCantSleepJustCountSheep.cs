// https://www.codewars.com/kata/5b077ebdaf15be5c7f000077/

public static class Kata
{
  public static string CountSheep(int n) => n > 0 ? CountSheep(n - 1) + $"{n} sheep..." : "";
}